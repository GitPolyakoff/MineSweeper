using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Threading;

namespace MineSweeper
{
    public partial class GameScreen : Form
    {
        int bombPercent = 10;//
        int width = 10;
        int height = 10;
        bool isFirstClick = true;
        FieldButton[,] field;
        int cellsOpened = 0;
        int bombs = 0;
        private readonly Stopwatch stopwatch = new Stopwatch();//создаём "секундомер", чтобы считать время от начала игры

        Color color;

        public Color Color
        {
            set { color = value; Invalidate(); }
            get { return color; }
        }


        public GameScreen()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;//открывает форму по центру монитора
            GameMenuPanel.Hide();
            PausePanel.Hide();

            StreamReader sr1 = new StreamReader(GlobalData.ColorForm);
            string str1;

            while (!sr1.EndOfStream)
            {
                str1 = sr1.ReadLine();
                //Проверка на пустую строку
                if (string.IsNullOrEmpty(str1))
                    continue;

                if (0 == int.Parse(str1))
                    color = Color.Red;

                if (1 == int.Parse(str1))
                    color = Color.DarkGoldenrod;

                if (2 == int.Parse(str1))
                    color = Color.DarkCyan;

                if (3 == int.Parse(str1))
                    color = Color.White;
               
                if (4 == int.Parse(str1))
                    color = Color.Honeydew;
          
            }
            sr1.Close();
            this.BackColor = color;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         
            this.FormBorderStyle = FormBorderStyle.None;//убираем кнопки навигации сверху

            StreamReader sr = new StreamReader(GlobalData.DifficultSetting);
            string str;
            while (!sr.EndOfStream)
            {
               
                str = sr.ReadLine();
                if (string.IsNullOrEmpty(str))
                    continue;
                if (0 == int.Parse(str))
                {
                    width = 5;
                    height = 5;
                }
                if (1 == int.Parse(str))
                {
                    width = 8;
                    height = 8;
                }
                if (2 == int.Parse(str))
                {
                    width = 10;
                    height = 10;
                }
            }
            sr.Close();
            field = new FieldButton[width, height];

            stopwatch.Start();//запустить секундомер
            Random random = new Random();
            //x И y - позиции создаваемых на форме кнопок
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    FieldButton newButton = new FieldButton
                    {
                        Location = new Point(x * 30, y * 30),
                        Size = new Size(30, 30),
                        isClickable = true//по дефолту все кнопки активны при создании
                    };
                    if (random.Next(0, 100) <= bombPercent)//выбирается число от 0 до 100
                    {
                        newButton.isBomb = true;//если выбранное число < процента бомб на поле, то нажатая кнопка - БОМБА
                        bombs++;
                    }
                    newButton.xCoord = x;
                    newButton.yCoord = y;
                    Controls.Add(newButton);
                    newButton.MouseUp += new MouseEventHandler(FieldButtonClick);//"прицепляем" созданную нами ф-ю на событие MouseUp
                    field[x, y] = newButton;
                  
                }
            }
            SoundPlayer SPNapr = new SoundPlayer(Properties.Resources.NAPRECHen);
            SPNapr.Play();

        }
      
        void FieldButtonClick(object sender, MouseEventArgs e)//функция нажатия на кнопку
        {
            FieldButton clickedButton = (FieldButton)sender;//явное преобразование объекта object в FieldButton
            if (e.Button == MouseButtons.Left && clickedButton.isClickable)
            {
                if (clickedButton.isBomb)
                {
                    if (isFirstClick)//делаем кнопку не бомбой при первом клике
                    {
                        clickedButton.isBomb = false;
                        isFirstClick = false;
                        bombs--;
                        //открыть все соседние клетки
                        OpenRegion(clickedButton.xCoord, clickedButton.yCoord, clickedButton);
                        clickedButton.BackColor = Color.Silver;
                    }
                    else
                        Detonation();
                }
                else
                    EmptyFieldButtonClick(clickedButton);//показываем количество бомб вокруг

                isFirstClick = false;
            }
            if (e.Button == MouseButtons.Right)//если нажата правая кнопка
            {
                clickedButton.isClickable = !clickedButton.isClickable;//если активна кнопка - делаем неактивной
                if (!clickedButton.isClickable && BackColor == Color.Red)
                {
                    clickedButton.Image = Properties.Resources.Флажок_синий;
                }
                else if (!clickedButton.isClickable)
                {
                    clickedButton.Image = Properties.Resources.Флажок1;
                }
                else
                {
                    clickedButton.Image = null;
                    clickedButton.BackColor = color;
                }
            }
            Victory();
        }

        void Detonation()
        {
            //окрываем при попадании на бомбу все бомбы
            foreach (FieldButton button in field)
            {
              
                 if (button.isBomb)
                {
                    button.BackColor = color;
                    button.Image = Properties.Resources.Бомба;
                    button.isClickable = false;
                }
                else
                {
                    button.Image = null;
                    button.Enabled = false;//делаем неактивными все кнопки при проигрыше
                }
            }
            TotalTimeLabel.Text += time_label.Text.ToString();
            WinLoseLabel.Text = "Вы проиграли!!!";
            SmailPictureBox.Image = new Bitmap(Properties.Resources.Смайл2);
            stopwatch.Stop(); //остановить секундомер
            GameMenuPanel.Show();
            PausePictureBox.Hide();
            ReplayPictureBox.Hide();
            SoundPlayer SPDET = new SoundPlayer(Properties.Resources.Finish);
            
            SPDET.Play();
        }
        
        void EmptyFieldButtonClick(FieldButton clickedButton)//открытие пустых
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //если совпадает с нажатой кнопкой
                    if (field[x, y] == clickedButton)
                        OpenRegion(x, y, clickedButton);
                }
            }
        }

        void OpenRegion(int xCoord, int yCoord, FieldButton clickedButton)//метод для автоматического раскрытия всех соседних пустых кнопок
        {
            Queue<FieldButton> queue = new Queue<FieldButton>();//очередь
            //если нет соседних клеток бомб то добавляем все соседние клетки вокруг этой клетки в очередь
            queue.Enqueue(clickedButton);//добавляем кнопку на которую нажали в очередь
            clickedButton.wasAdded = true;
            while (queue.Count > 0)
            {
                FieldButton currentCell = queue.Dequeue();//получаем первый эл-т нашей очереди
                OpenCell(currentCell.xCoord, currentCell.yCoord, currentCell);
                cellsOpened++;
                if (CountBombsAround(currentCell.xCoord, currentCell.yCoord) == 0)
                {
                    //проходимся по соседним клеткам вокруг нажатой кнопки
                    for (int y = currentCell.yCoord - 1; y <= currentCell.yCoord + 1; y++)
                    {
                        for (int x = currentCell.xCoord - 1; x <= currentCell.xCoord + 1; x++)
                        {
                            //исключаем из рассмотрения начальные значения координат кнопки
                            if (x == currentCell.xCoord && y == currentCell.yCoord)
                                continue;

                            if (x >= 0 && x < width && y < height && y >= 0)//проверка что не выходим за границы
                            {
                                if (!field[x, y].wasAdded)//если кнопка не была добавлена в очередь, то добавить её
                                {
                                    queue.Enqueue(field[x, y]);//вставляем в очередь кнопку
                                    field[x, y].wasAdded = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        void OpenCell(int x, int y, FieldButton clickedButton)//открыть кнопку на которую нажали и показать кол-во бомб вокруг и деактивируеим её
        {
            int bombsAround = CountBombsAround(x, y);
            if (bombsAround == 0)
            {
                //если 0 бомб вокруг кнопки то ничего не делаем
            }
            else
            {
                int newSize = 12;
                clickedButton.Font = new Font(clickedButton.Font.FontFamily, newSize);
                clickedButton.Text = "" + bombsAround;//считаем количество бомб вокруг в поле 3х3 и выводим текст в нажатую кнопку
            }

            clickedButton.Enabled = false;//делаем неактивной кнопку после нажатия на неё
            clickedButton.BackColor = Color.Silver;
            clickedButton.Image = null;
        }

        int CountBombsAround(int xCoord, int yCoord)//подсчёт бомб вокруг кнопки в поле 3х3
        {
            int bombsAround = 0;
            for (int x = xCoord - 1; x <= xCoord + 1; x++)
            {
                for (int y = yCoord - 1; y <= yCoord + 1; y++)
                {
                    //проверка на нажатие на кнопки находящиеся у границ поля
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        if (field[x, y].isBomb == true)
                            bombsAround++;
                    }
                }
            }
            return bombsAround;
        }

        void Victory()
        {
            int cells = width * height;//считаем кол-во всех клеток
            int emptyCells = cells - bombs;//кол-во пустых клеток
            if (cellsOpened >= emptyCells)//условие победы
            {
                TotalTimeLabel.Text += time_label.Text.ToString();
                stopwatch.Stop(); //остановить секундомер
                WinLoseLabel.Text = "Вы победили!!!";
                SmailPictureBox.Image = new Bitmap(Properties.Resources.Смайл3);
                GameMenuPanel.Show();

                StreamReader sr = new StreamReader(GlobalData.DifficultSetting); //Запись времени в зависимости от уровня сложности
                string str;
                while (!sr.EndOfStream)
                {

                    str = sr.ReadLine();
                    if (string.IsNullOrEmpty(str))
                        continue;
                    if (0 == int.Parse(str))
                    {
                        GlobalData.PlayerTimeEasy = stopwatch.Elapsed.ToString("mm\\:ss");
                    }
                    if (1 == int.Parse(str))
                    {
                        GlobalData.PlayerTimeMedium = stopwatch.Elapsed.ToString("mm\\:ss");
                    }
                    if (2 == int.Parse(str))
                    {
                        GlobalData.PlayerTimeHard = stopwatch.Elapsed.ToString("mm\\:ss");
                    }
                }
                sr.Close();
                
                foreach (FieldButton button in field)
                {
                    button.isClickable = false;//делаем "ненажимаемыми" все кнопки при победе
                    button.Enabled = false;
                }
                PausePictureBox.Hide();
                ReplayPictureBox.Hide();
                SoundPlayer SPFinishGood = new SoundPlayer(Properties.Resources.Finish_Good);
                SPFinishGood.Play();
            }
        }

        private void RestartLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            time_label.Text = stopwatch.Elapsed.ToString("mm\\:ss");
        }

        private void ReplayPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            PausePanel.Show();
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
            stopwatch.Stop();
            foreach (FieldButton button in field)
            {
                button.isClickable = false;
                button.Enabled = false;
                ReplayPictureBox.Hide();
                
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            PausePanel.Hide();
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
            stopwatch.Start();
            ReplayPictureBox.Show();
            foreach (FieldButton button in field)
            {
                button.isClickable = true;
                button.Enabled = true;
            }
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
        }

        private void GameScreen_Shown(object sender, EventArgs e)
        {
           // Thread.Sleep(700);
            SoundPlayer SPNapr = new SoundPlayer(Properties.Resources.NAPRECHen);
            SPNapr.Play();
        }
        
    }

    public class FieldButton : Button
    {
        public bool isBomb;//хранит информацию является ли кнопка бомбой
        public bool isClickable;//храниит информацию можно ли нажать на кнопку или нет
        public bool wasAdded;//хранит информацию об уже открытых клетках
        public int xCoord;
        public int yCoord;
    }
}