using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MineSweeper
{
    public partial class LeaderScreen : Form
    {
        string time;       
        public List<Player> players;
        public LeaderScreen()
        {
            InitializeComponent();
            players = new List<Player>();
            this.FormBorderStyle = FormBorderStyle.None;//убираем кнопки навигации сверху
            StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            Time = "";
            Player.ReadFile(GlobalData.LdrFileName, players);
            FillListBox(players, LeaderlistBox);
            FolderTextBox.Text = "Путь: " + GlobalData.LdrFileName;

            Player pl = new Player();
            pl.NickName = GlobalData.PlayerName;
            pl.Time = GlobalData.PlayerTime;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].NickName == pl.NickName)
                {
                    LeaderlistBox.Items.RemoveAt(i);
                    players.RemoveAt(i);
                    continue;
                }
            }
            players.Add(pl);
            LeaderlistBox.Items.Add($"{pl.NickName} | {pl.Time}");
            Player.SaveFile(GlobalData.LdrFileName, players);
            FillListBox(players, LeaderlistBox);

        }
        public string Time
        {
            set { time = value; }
            get { return time; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            SoundPlayer SPEsc = new SoundPlayer(Properties.Resources.ESC);
            SPEsc.Play();
        }


        protected void FillListBox(List<Player> players,
            ListBox listBox)
        {
            if (players == null || listBox == null)
                return;
            listBox.Items.Clear();
            //Сортировка таблицы лидеров
            var PlayerTimeSorted = from pl in players
                                   orderby pl.Time, pl.NickName
                                   select pl;
            // заполнение списка
            int place = 0;
            foreach (Player pl in PlayerTimeSorted)
            {
                place++;
                listBox.Items.Add($"{place}. {pl.NickName} | {pl.Time}");
            }
                
        }


    }
}
