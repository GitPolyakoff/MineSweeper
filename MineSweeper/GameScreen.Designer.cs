
namespace MineSweeper
{
    partial class GameScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.RestartLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.GameMenuPanel = new System.Windows.Forms.Panel();
            this.WinLoseLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.SmailPictureBox = new System.Windows.Forms.PictureBox();
            this.ReplayPictureBox = new System.Windows.Forms.PictureBox();
            this.PausePictureBox = new System.Windows.Forms.PictureBox();
            this.PausePanel = new System.Windows.Forms.Panel();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).BeginInit();
            this.PausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeLabel.Location = new System.Drawing.Point(70, 123);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(56, 20);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartLabel.Location = new System.Drawing.Point(64, 88);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(69, 20);
            this.RestartLabel.TabIndex = 1;
            this.RestartLabel.Text = "Restart";
            this.RestartLabel.Click += new System.EventHandler(this.RestartLabel_Click);
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTimeLabel.Location = new System.Drawing.Point(35, 54);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(100, 20);
            this.TotalTimeLabel.TabIndex = 0;
            this.TotalTimeLabel.Text = "Your Time: ";
            // 
            // GameMenuPanel
            // 
            this.GameMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameMenuPanel.Controls.Add(this.WinLoseLabel);
            this.GameMenuPanel.Controls.Add(this.HomeLabel);
            this.GameMenuPanel.Controls.Add(this.TotalTimeLabel);
            this.GameMenuPanel.Controls.Add(this.RestartLabel);
            this.GameMenuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameMenuPanel.Location = new System.Drawing.Point(87, 74);
            this.GameMenuPanel.Name = "GameMenuPanel";
            this.GameMenuPanel.Size = new System.Drawing.Size(200, 169);
            this.GameMenuPanel.TabIndex = 1;
            // 
            // WinLoseLabel
            // 
            this.WinLoseLabel.AutoSize = true;
            this.WinLoseLabel.Location = new System.Drawing.Point(34, 23);
            this.WinLoseLabel.Name = "WinLoseLabel";
            this.WinLoseLabel.Size = new System.Drawing.Size(122, 20);
            this.WinLoseLabel.TabIndex = 3;
            this.WinLoseLabel.Text = "WinLoseLabel";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(305, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(55, 22);
            this.time_label.TabIndex = 2;
            this.time_label.Text = "00:00";
            // 
            // SmailPictureBox
            // 
            this.SmailPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SmailPictureBox.Image = global::MineSweeper.Properties.Resources.Смайл1;
            this.SmailPictureBox.Location = new System.Drawing.Point(306, 37);
            this.SmailPictureBox.Name = "SmailPictureBox";
            this.SmailPictureBox.Size = new System.Drawing.Size(50, 50);
            this.SmailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmailPictureBox.TabIndex = 3;
            this.SmailPictureBox.TabStop = false;
            // 
            // ReplayPictureBox
            // 
            this.ReplayPictureBox.Image = global::MineSweeper.Properties.Resources.Перезагрузка;
            this.ReplayPictureBox.Location = new System.Drawing.Point(325, 224);
            this.ReplayPictureBox.Name = "ReplayPictureBox";
            this.ReplayPictureBox.Size = new System.Drawing.Size(35, 35);
            this.ReplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReplayPictureBox.TabIndex = 4;
            this.ReplayPictureBox.TabStop = false;
            this.ReplayPictureBox.Click += new System.EventHandler(this.ReplayPictureBox_Click);
            // 
            // PausePictureBox
            // 
            this.PausePictureBox.Image = global::MineSweeper.Properties.Resources.Пауза;
            this.PausePictureBox.Location = new System.Drawing.Point(325, 264);
            this.PausePictureBox.Name = "PausePictureBox";
            this.PausePictureBox.Size = new System.Drawing.Size(35, 35);
            this.PausePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PausePictureBox.TabIndex = 5;
            this.PausePictureBox.TabStop = false;
            this.PausePictureBox.Click += new System.EventHandler(this.PausePictureBox_Click);
            // 
            // PausePanel
            // 
            this.PausePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PausePanel.Controls.Add(this.ToMenuButton);
            this.PausePanel.Controls.Add(this.ContinueButton);
            this.PausePanel.Controls.Add(this.label1);
            this.PausePanel.Location = new System.Drawing.Point(76, 120);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(221, 72);
            this.PausePanel.TabIndex = 4;
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMenuButton.Location = new System.Drawing.Point(115, 41);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(100, 25);
            this.ToMenuButton.TabIndex = 2;
            this.ToMenuButton.Text = "Выйти в меню";
            this.ToMenuButton.UseVisualStyleBackColor = true;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.Location = new System.Drawing.Point(5, 41);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(100, 25);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра приостановлена";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.PausePanel);
            this.Controls.Add(this.PausePictureBox);
            this.Controls.Add(this.ReplayPictureBox);
            this.Controls.Add(this.SmailPictureBox);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.GameMenuPanel);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GameMenuPanel.ResumeLayout(false);
            this.GameMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PausePictureBox)).EndInit();
            this.PausePanel.ResumeLayout(false);
            this.PausePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label RestartLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Panel GameMenuPanel;
        private System.Windows.Forms.Label WinLoseLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox SmailPictureBox;
        private System.Windows.Forms.PictureBox ReplayPictureBox;
        private System.Windows.Forms.PictureBox PausePictureBox;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label label1;
    }
}

