﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class NameForm : UserControl
    {
        public NameForm()
        {
            InitializeComponent();
        }
        
        private void OKButton_Click(object sender, EventArgs e)
        {
            GlobalData.PlayerName = NameTextBox.Text;
        }
    }
}