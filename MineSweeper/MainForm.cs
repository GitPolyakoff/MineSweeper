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

        Color color = Color.LightGray;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;                      
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
