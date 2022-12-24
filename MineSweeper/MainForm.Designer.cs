
namespace MineSweeper
{
    partial class MainForm
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
            this.button_newGame = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_leader = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameForm1 = new MineSweeper.NameForm();
            this.Settings_pictureBox = new System.Windows.Forms.PictureBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.picture_setting = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_setting)).BeginInit();
            this.SuspendLayout();
            // 
            // button_newGame
            // 
            this.button_newGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_newGame.Location = new System.Drawing.Point(130, 121);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(104, 53);
            this.button_newGame.TabIndex = 0;
            this.button_newGame.Text = "Новая игра";
            this.button_newGame.UseVisualStyleBackColor = true;
            this.button_newGame.Click += new System.EventHandler(this.button_newGame_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Location = new System.Drawing.Point(129, 238);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(106, 52);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_leader
            // 
            this.button_leader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_leader.FlatAppearance.BorderSize = 3;
            this.button_leader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_leader.Location = new System.Drawing.Point(129, 180);
            this.button_leader.Name = "button_leader";
            this.button_leader.Size = new System.Drawing.Size(106, 52);
            this.button_leader.TabIndex = 3;
            this.button_leader.Text = "Список лидеров";
            this.button_leader.UseVisualStyleBackColor = true;
            this.button_leader.Click += new System.EventHandler(this.button_leader_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_leader, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_exit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameForm1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Settings_pictureBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DifficultyLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_newGame, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 428);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MineSweeper.Properties.Resources.Меню1;
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameForm1
            // 
            this.nameForm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameForm1.Color = System.Drawing.Color.Empty;
            this.nameForm1.Location = new System.Drawing.Point(74, 296);
            this.nameForm1.Name = "nameForm1";
            this.nameForm1.Size = new System.Drawing.Size(215, 89);
            this.nameForm1.TabIndex = 5;
            // 
            // Settings_pictureBox
            // 
            this.Settings_pictureBox.Image = global::MineSweeper.Properties.Resources.Настройка1;
            this.Settings_pictureBox.Location = new System.Drawing.Point(3, 391);
            this.Settings_pictureBox.Name = "Settings_pictureBox";
            this.Settings_pictureBox.Size = new System.Drawing.Size(39, 36);
            this.Settings_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings_pictureBox.TabIndex = 6;
            this.Settings_pictureBox.TabStop = false;
            this.Settings_pictureBox.Click += new System.EventHandler(this.Settings_pictureBox_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyLabel.Location = new System.Drawing.Point(48, 389);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(171, 40);
            this.DifficultyLabel.TabIndex = 7;
            this.DifficultyLabel.Text = "Выберите уровень сложности!!!!";
            // 
            // picture_setting
            // 
            this.picture_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_setting.Enabled = false;
            this.picture_setting.Image = global::MineSweeper.Properties.Resources.Настройка1;
            this.picture_setting.Location = new System.Drawing.Point(12, 69);
            this.picture_setting.Name = "picture_setting";
            this.picture_setting.Size = new System.Drawing.Size(30, 30);
            this.picture_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_setting.TabIndex = 2;
            this.picture_setting.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(364, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picture_setting);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(380, 410);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_setting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_newGame;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox picture_setting;
        private System.Windows.Forms.Button button_leader;
        private NameForm nameForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Settings_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DifficultyLabel;
    }
}