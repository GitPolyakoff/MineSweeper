﻿using System;
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
    public partial class SettingsScreen : Form
    {

        public SettingsScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//убираем кнопки навигации сверху
            StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();

            mainForm.Show();
        }

        private void SelectedColorButton_Click(object sender, EventArgs e)
        {
            string path = GlobalData.DifficultSetting;
            StreamWriter writer = null;

            switch (ColorComboBox.SelectedIndex)
            {
                case 0: //красный
                    this.BackColor = Color.Red;
                    break;

                case 1: //голубой
                    this.BackColor = Color.SkyBlue;
                    break;

                case 2: //жёлтый
                    this.BackColor = Color.Yellow;
                    break;

                case 3: //системный
                    this.BackColor = Color.White;
                    break;
            }

            try
            {
                writer = new StreamWriter(path, false, Encoding.Default);
                writer.WriteLine(DifficultyComboBox.SelectedIndex);
                writer.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка при сохранении файла");
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }
        }
    }
}