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
            if (NameTextBox.Text != String.Empty)
            {
                SoundPlayer SPDone = new SoundPlayer(Properties.Resources.DONE);
                SPDone.Play();
            }
           
        }


        private void NamePanel_Paint(object sender, PaintEventArgs e)
        {
            label1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            OKButton.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            
        }
        
        
    }
}
