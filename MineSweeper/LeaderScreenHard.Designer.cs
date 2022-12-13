
namespace MineSweeper
{
    partial class LeaderScreenHard
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
            this.HardFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaderGroupBox = new System.Windows.Forms.GroupBox();
            this.HardLeaderlistBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HardFolderTextBox
            // 
            this.HardFolderTextBox.Location = new System.Drawing.Point(52, 304);
            this.HardFolderTextBox.Multiline = true;
            this.HardFolderTextBox.Name = "HardFolderTextBox";
            this.HardFolderTextBox.Size = new System.Drawing.Size(189, 52);
            this.HardFolderTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Путь:";
            // 
            // LeaderGroupBox
            // 
            this.LeaderGroupBox.Controls.Add(this.HardLeaderlistBox);
            this.LeaderGroupBox.Location = new System.Drawing.Point(11, 36);
            this.LeaderGroupBox.Name = "LeaderGroupBox";
            this.LeaderGroupBox.Size = new System.Drawing.Size(233, 265);
            this.LeaderGroupBox.TabIndex = 17;
            this.LeaderGroupBox.TabStop = false;
            this.LeaderGroupBox.Text = "Лидеры:";
            // 
            // HardLeaderlistBox
            // 
            this.HardLeaderlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardLeaderlistBox.FormattingEnabled = true;
            this.HardLeaderlistBox.Location = new System.Drawing.Point(3, 16);
            this.HardLeaderlistBox.Name = "HardLeaderlistBox";
            this.HardLeaderlistBox.Size = new System.Drawing.Size(227, 246);
            this.HardLeaderlistBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MineSweeper.Properties.Resources.Домой1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LeaderScreenHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 371);
            this.Controls.Add(this.HardFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeaderGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LeaderScreenHard";
            this.Text = "LeaderScreenHard";
            this.LeaderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HardFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LeaderGroupBox;
        private System.Windows.Forms.ListBox HardLeaderlistBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}