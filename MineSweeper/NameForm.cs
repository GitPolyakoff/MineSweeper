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
    public partial class NameForm : UserControl
    {
        public NameForm()
        {
            InitializeComponent();
        }
        Color color;

        public Color Color
        {
            set { color = value; Invalidate(); }
            get { return color; }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GlobalData.PlayerName = NameTextBox.Text;
        }

        private void NamePanel_Paint(object sender, PaintEventArgs e)
        {
        }
           
    }
}
