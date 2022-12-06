
namespace MineSweeper
{
    partial class SettingsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Красный",
            "Голубой",
            "Жёлтый",
            "Системный",
            "Серый"});
            this.ColorComboBox.Location = new System.Drawing.Point(22, 55);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(135, 21);
            this.ColorComboBox.TabIndex = 2;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(22, 89);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(328, 37);
            this.SaveSettingsButton.TabIndex = 3;
            this.SaveSettingsButton.Text = "Применить настройки";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MineSweeper.Properties.Resources.Домой1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DifficultyComboBox
            // 
            this.DifficultyComboBox.FormattingEnabled = true;
            this.DifficultyComboBox.Items.AddRange(new object[] {
            "Проще простого (поле 5х5)",
            "Любитель (поле 8х8)",
            "Опытный сапёр (поле 10х10)"});
            this.DifficultyComboBox.Location = new System.Drawing.Point(172, 55);
            this.DifficultyComboBox.Name = "DifficultyComboBox";
            this.DifficultyComboBox.Size = new System.Drawing.Size(178, 21);
            this.DifficultyComboBox.TabIndex = 4;
            this.DifficultyComboBox.SelectionChangeCommitted += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 371);
            this.Controls.Add(this.DifficultyComboBox);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.ComboBox DifficultyComboBox;
    }
}