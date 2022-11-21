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
            Player pl = new Player();
            pl.NickName = GlobalData.PlayerName;
            players.Add(pl);
            pl.Time = GlobalData.PlayerTime;
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
        }

        
        protected void FillListBox(List<Player> players,
            ListBox listBox)
        {
            if (players == null || listBox == null)
                return;

            listBox.Items.Clear();

            foreach (Player pl in players)
                listBox.Items.Add(pl.NickName + " | " + pl.Time);
        }

        
    }
}
