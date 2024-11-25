namespace MenuView
{
    partial class View
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
            this.button_settings = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_statistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_settings.Location = new System.Drawing.Point(236, 106);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(319, 65);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_play.Location = new System.Drawing.Point(236, 206);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(319, 65);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "Играть";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_statistics
            // 
            this.button_statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.button_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_statistics.Location = new System.Drawing.Point(236, 305);
            this.button_statistics.Name = "button_statistics";
            this.button_statistics.Size = new System.Drawing.Size(319, 65);
            this.button_statistics.TabIndex = 2;
            this.button_statistics.Text = "Статистика";
            this.button_statistics.UseVisualStyleBackColor = false;
            this.button_statistics.Click += new System.EventHandler(this.button_statistics_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(830, 517);
            this.Controls.Add(this.button_statistics);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_settings);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_statistics;
    }
}