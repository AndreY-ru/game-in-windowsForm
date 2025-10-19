namespace FerstGame
{
    partial class Form
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
            this.gg = new System.Windows.Forms.PictureBox();
            this.foe = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Heat1 = new System.Windows.Forms.Label();
            this.Heat2 = new System.Windows.Forms.Label();
            this.Heat3 = new System.Windows.Forms.Label();
            this.Heat4 = new System.Windows.Forms.Label();
            this.Heat5 = new System.Windows.Forms.Label();
            this.labelwin = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe)).BeginInit();
            this.SuspendLayout();
            // 
            // gg
            // 
            this.gg.BackColor = System.Drawing.Color.Green;
            this.gg.Location = new System.Drawing.Point(327, 127);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(32, 32);
            this.gg.TabIndex = 0;
            this.gg.TabStop = false;
            // 
            // foe
            // 
            this.foe.BackColor = System.Drawing.Color.Red;
            this.foe.Location = new System.Drawing.Point(295, 289);
            this.foe.Name = "foe";
            this.foe.Size = new System.Drawing.Size(64, 64);
            this.foe.TabIndex = 1;
            this.foe.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 33;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Maroon;
            this.labelLose.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelLose.Location = new System.Drawing.Point(12, 192);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(462, 65);
            this.labelLose.TabIndex = 4;
            this.labelLose.Text = "Кусь! Тебя съели(";
            // 
            // Replay
            // 
            this.Replay.BackColor = System.Drawing.Color.Maroon;
            this.Replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replay.Font = new System.Drawing.Font("Open Sans", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Replay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Replay.Location = new System.Drawing.Point(12, 9);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(222, 81);
            this.Replay.TabIndex = 5;
            this.Replay.Text = "Заново";
            this.Replay.UseVisualStyleBackColor = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Maroon;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Open Sans Extrabold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Location = new System.Drawing.Point(399, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 78);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Heat1
            // 
            this.Heat1.AutoSize = true;
            this.Heat1.BackColor = System.Drawing.Color.Maroon;
            this.Heat1.Font = new System.Drawing.Font("Open Sans", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heat1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Heat1.Location = new System.Drawing.Point(1, -1);
            this.Heat1.Name = "Heat1";
            this.Heat1.Size = new System.Drawing.Size(17, 28);
            this.Heat1.TabIndex = 7;
            this.Heat1.Text = " ";
            // 
            // Heat2
            // 
            this.Heat2.AutoSize = true;
            this.Heat2.BackColor = System.Drawing.Color.Maroon;
            this.Heat2.Font = new System.Drawing.Font("Open Sans", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heat2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Heat2.Location = new System.Drawing.Point(24, -1);
            this.Heat2.Name = "Heat2";
            this.Heat2.Size = new System.Drawing.Size(17, 28);
            this.Heat2.TabIndex = 8;
            this.Heat2.Text = " ";
            // 
            // Heat3
            // 
            this.Heat3.AutoSize = true;
            this.Heat3.BackColor = System.Drawing.Color.Maroon;
            this.Heat3.Font = new System.Drawing.Font("Open Sans", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heat3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Heat3.Location = new System.Drawing.Point(47, -1);
            this.Heat3.Name = "Heat3";
            this.Heat3.Size = new System.Drawing.Size(17, 28);
            this.Heat3.TabIndex = 9;
            this.Heat3.Text = " ";
            // 
            // Heat4
            // 
            this.Heat4.AutoSize = true;
            this.Heat4.BackColor = System.Drawing.Color.Maroon;
            this.Heat4.Font = new System.Drawing.Font("Open Sans", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heat4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Heat4.Location = new System.Drawing.Point(70, -1);
            this.Heat4.Name = "Heat4";
            this.Heat4.Size = new System.Drawing.Size(17, 28);
            this.Heat4.TabIndex = 9;
            this.Heat4.Text = " ";
            // 
            // Heat5
            // 
            this.Heat5.AutoSize = true;
            this.Heat5.BackColor = System.Drawing.Color.Maroon;
            this.Heat5.Font = new System.Drawing.Font("Open Sans", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heat5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Heat5.Location = new System.Drawing.Point(93, -1);
            this.Heat5.Name = "Heat5";
            this.Heat5.Size = new System.Drawing.Size(17, 28);
            this.Heat5.TabIndex = 9;
            this.Heat5.Text = " ";
            // 
            // labelwin
            // 
            this.labelwin.AutoSize = true;
            this.labelwin.BackColor = System.Drawing.Color.Maroon;
            this.labelwin.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelwin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelwin.Location = new System.Drawing.Point(132, 192);
            this.labelwin.Name = "labelwin";
            this.labelwin.Size = new System.Drawing.Size(227, 65);
            this.labelwin.TabIndex = 10;
            this.labelwin.Text = "Победа!";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Maroon;
            this.level.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.level.Location = new System.Drawing.Point(103, 127);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(278, 65);
            this.level.TabIndex = 11;
            this.level.Text = "Уровень 1";
            this.level.Click += new System.EventHandler(this.level_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Open Sans", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(137, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(222, 81);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Старт!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Maroon;
            this.labelCoins.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCoins.Location = new System.Drawing.Point(1, 335);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(463, 65);
            this.labelCoins.TabIndex = 13;
            this.labelCoins.Text = "Собрано монет: 0";
            this.labelCoins.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(486, 441);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.level);
            this.Controls.Add(this.labelwin);
            this.Controls.Add(this.Heat5);
            this.Controls.Add(this.Heat4);
            this.Controls.Add(this.Heat3);
            this.Controls.Add(this.Heat2);
            this.Controls.Add(this.Heat1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.foe);
            this.Controls.Add(this.gg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gg;
        private System.Windows.Forms.PictureBox foe;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Heat1;
        private System.Windows.Forms.Label Heat2;
        private System.Windows.Forms.Label Heat3;
        private System.Windows.Forms.Label Heat4;
        private System.Windows.Forms.Label Heat5;
        private System.Windows.Forms.Label labelwin;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelCoins;
    }
}

