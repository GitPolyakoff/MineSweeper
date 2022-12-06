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
using System.Threading;

namespace MineSweeper
{
    public partial class MainForm : Form
    {


        Color color;
        public MainForm()
        {
          
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.None;//убираем кнопки навигации сверху
            StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            StreamReader sr1 = new StreamReader(GlobalData.ColorForm);
            string str1;

            while (!sr1.EndOfStream)
            {
                str1 = sr1.ReadLine();
                //Проверка на пустую строку
                if (string.IsNullOrEmpty(str1))
                    continue;
                if (0 == int.Parse(str1))
                {
                    color = Color.Red;
                }
                if (1 == int.Parse(str1))
                {
                    color = Color.SkyBlue;
                }
                if (2 == int.Parse(str1))
                {
                    color = Color.Yellow;
                }
                if (3 == int.Parse(str1))
                {
                    color = Color.White;
                }
                if (4 == int.Parse(str1))
                {
                    color = Color.Gray;
                  
                }
            }
            sr1.Close();
            this.BackColor = color;
        
        }

        private void button_newGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
            gameScreen.BackColor = color;


           SoundPlayer SPGo = new SoundPlayer(Properties.Resources.GO_);
           SPGo.Play();
            Thread.Sleep(600);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            SoundPlayer SPEnd = new SoundPlayer(Properties.Resources.SWINGOUT);
            SPEnd.Play();
            Thread.Sleep(500);
            Application.Exit();

        }

        private void button_leader_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderScreen leader = new LeaderScreen();
            leader.Show();
            leader.BackColor = color;
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
        }

        private void Settings_pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsScreen settings = new SettingsScreen();
            settings.Show();
            settings.BackColor = color;
            SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
            SPDone.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Image = Properties.Resources.S_T_A_L_K_E_R__Logo;
            button_newGame.Text = "На охоту";
            button_newGame.BackColor = Color.Green;
            button_leader.Text = "Легендарные сталкеры";
            button_leader.BackColor = Color.Green;
            button_exit.Text = "Слабак ты меченный";
            button_exit.BackColor = Color.Red;
            BackColor = Color.DarkGray;
            
        }


        private void MainForm_Load_1(object sender, EventArgs e)
        {

            System.Media.SoundPlayer SPMM = new System.Media.SoundPlayer(
                   Properties.Resources.MEnu);
            SPMM.PlayLooping();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            System.Media.SoundPlayer SPMM = new System.Media.SoundPlayer(
                 Properties.Resources.MEnu);
            SPMM.PlayLooping();
        }
    }
}
