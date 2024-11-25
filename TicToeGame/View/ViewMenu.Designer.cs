namespace View
{
    partial class ViewMenu
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
            this.settings_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.statistics_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_button.Location = new System.Drawing.Point(200, 94);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(355, 75);
            this.settings_button.TabIndex = 0;
            this.settings_button.Text = "Настройки";
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // play_button
            // 
            this.play_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_button.Location = new System.Drawing.Point(200, 189);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(355, 75);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Играть";
            this.play_button.UseVisualStyleBackColor = false;
            // 
            // statistics_button
            // 
            this.statistics_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statistics_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statistics_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.statistics_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistics_button.Location = new System.Drawing.Point(200, 292);
            this.statistics_button.Name = "statistics_button";
            this.statistics_button.Size = new System.Drawing.Size(355, 75);
            this.statistics_button.TabIndex = 2;
            this.statistics_button.Text = "Статистика";
            this.statistics_button.UseVisualStyleBackColor = false;
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(793, 514);
            this.Controls.Add(this.statistics_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.settings_button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.Name = "ViewMenu";
            this.Text = "ViewMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button statistics_button;
    }
}