
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
            this.SelectedColorButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            "Системный"});
            this.ColorComboBox.Location = new System.Drawing.Point(34, 55);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(135, 21);
            this.ColorComboBox.TabIndex = 2;
            // 
            // SelectedColorButton
            // 
            this.SelectedColorButton.Location = new System.Drawing.Point(191, 55);
            this.SelectedColorButton.Name = "SelectedColorButton";
            this.SelectedColorButton.Size = new System.Drawing.Size(135, 25);
            this.SelectedColorButton.TabIndex = 3;
            this.SelectedColorButton.Text = "Применить";
            this.SelectedColorButton.UseVisualStyleBackColor = true;
            this.SelectedColorButton.Click += new System.EventHandler(this.SelectedColorButton_Click);
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
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 371);
            this.Controls.Add(this.SelectedColorButton);
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
        private System.Windows.Forms.Button SelectedColorButton;
    }
}