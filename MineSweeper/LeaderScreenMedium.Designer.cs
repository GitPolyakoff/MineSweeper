
namespace MineSweeper
{
    partial class LeaderScreenMedium
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MediumFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaderGroupBox = new System.Windows.Forms.GroupBox();
            this.MediumLeaderlistBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LeaderGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // MediumFolderTextBox
            // 
            this.MediumFolderTextBox.Location = new System.Drawing.Point(52, 304);
            this.MediumFolderTextBox.Multiline = true;
            this.MediumFolderTextBox.Name = "MediumFolderTextBox";
            this.MediumFolderTextBox.Size = new System.Drawing.Size(189, 52);
            this.MediumFolderTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Путь:";
            // 
            // LeaderGroupBox
            // 
            this.LeaderGroupBox.Controls.Add(this.MediumLeaderlistBox);
            this.LeaderGroupBox.Location = new System.Drawing.Point(11, 36);
            this.LeaderGroupBox.Name = "LeaderGroupBox";
            this.LeaderGroupBox.Size = new System.Drawing.Size(233, 265);
            this.LeaderGroupBox.TabIndex = 16;
            this.LeaderGroupBox.TabStop = false;
            this.LeaderGroupBox.Text = "Лидеры:";
            // 
            // MediumLeaderlistBox
            // 
            this.MediumLeaderlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediumLeaderlistBox.FormattingEnabled = true;
            this.MediumLeaderlistBox.Location = new System.Drawing.Point(3, 16);
            this.MediumLeaderlistBox.Name = "MediumLeaderlistBox";
            this.MediumLeaderlistBox.Size = new System.Drawing.Size(227, 246);
            this.MediumLeaderlistBox.TabIndex = 0;
            // 
            // LeaderScreenMedium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 371);
            this.Controls.Add(this.MediumFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeaderGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LeaderScreenMedium";
            this.Text = "LeaderScreenMedium";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LeaderGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MediumFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LeaderGroupBox;
        private System.Windows.Forms.ListBox MediumLeaderlistBox;
    }
}