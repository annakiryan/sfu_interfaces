namespace View
{
    partial class ViewStatistics
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_of_played_games = new System.Windows.Forms.Label();
            this.num_of_x_wins = new System.Windows.Forms.Label();
            this.num_of_o_wins = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.label.Location = new System.Drawing.Point(48, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(227, 36);
            this.label.TabIndex = 0;
            this.label.Text = "Количество игр:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество побед X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(48, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество побед O:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_played_games
            // 
            this.num_of_played_games.AutoSize = true;
            this.num_of_played_games.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_of_played_games.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.num_of_played_games.Location = new System.Drawing.Point(281, 39);
            this.num_of_played_games.Name = "num_of_played_games";
            this.num_of_played_games.Size = new System.Drawing.Size(30, 36);
            this.num_of_played_games.TabIndex = 3;
            this.num_of_played_games.Text = "0";
            this.num_of_played_games.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_x_wins
            // 
            this.num_of_x_wins.AutoSize = true;
            this.num_of_x_wins.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_of_x_wins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.num_of_x_wins.Location = new System.Drawing.Point(337, 118);
            this.num_of_x_wins.Name = "num_of_x_wins";
            this.num_of_x_wins.Size = new System.Drawing.Size(30, 36);
            this.num_of_x_wins.TabIndex = 4;
            this.num_of_x_wins.Text = "0";
            this.num_of_x_wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_of_o_wins
            // 
            this.num_of_o_wins.AutoSize = true;
            this.num_of_o_wins.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_of_o_wins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.num_of_o_wins.Location = new System.Drawing.Point(340, 192);
            this.num_of_o_wins.Name = "num_of_o_wins";
            this.num_of_o_wins.Size = new System.Drawing.Size(30, 36);
            this.num_of_o_wins.TabIndex = 5;
            this.num_of_o_wins.Text = "0";
            this.num_of_o_wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_of_o_wins);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.num_of_x_wins);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_of_played_games);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.groupBox1.Location = new System.Drawing.Point(160, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 263);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // ViewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(785, 543);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewStatistics";
            this.Text = "Статистика";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label num_of_played_games;
        private System.Windows.Forms.Label num_of_x_wins;
        private System.Windows.Forms.Label num_of_o_wins;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

