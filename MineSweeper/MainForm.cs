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
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_leader_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaderScreen leader = new LeaderScreen();
            leader.Show();
            leader.BackColor = color;
        }

        private void Settings_pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsScreen settings = new SettingsScreen();
            settings.Show();
            settings.BackColor = color;
        }
    }
}
