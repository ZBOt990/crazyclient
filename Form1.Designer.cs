namespace cclauncher
{
    partial class Form1
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
            this.LAUNCH = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.exit = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAUNCH
            // 
            this.LAUNCH.Animated = true;
            this.LAUNCH.AutoRoundedCorners = true;
            this.LAUNCH.BackColor = System.Drawing.Color.Transparent;
            this.LAUNCH.BorderRadius = 53;
            this.LAUNCH.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LAUNCH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LAUNCH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LAUNCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LAUNCH.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LAUNCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LAUNCH.FillColor = System.Drawing.Color.DarkGray;
            this.LAUNCH.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LAUNCH.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAUNCH.ForeColor = System.Drawing.Color.White;
            this.LAUNCH.Location = new System.Drawing.Point(371, 285);
            this.LAUNCH.Name = "LAUNCH";
            this.LAUNCH.Size = new System.Drawing.Size(299, 108);
            this.LAUNCH.TabIndex = 0;
            this.LAUNCH.Text = "LAUNCH";
            this.LAUNCH.UseTransparentBackground = true;
            this.LAUNCH.Click += new System.EventHandler(this.LAUNCH_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::cclauncher.Properties.Resources.Untitled_Design;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel.Controls.Add(this.guna2HtmlLabel1);
            this.panel.FillColor = System.Drawing.Color.Black;
            this.panel.FillColor2 = System.Drawing.Color.Black;
            this.panel.FillColor3 = System.Drawing.Color.Black;
            this.panel.FillColor4 = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1046, 83);
            this.panel.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(311, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(477, 75);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "CRAZY CLIENT";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(945, 498);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cclauncher.Properties.Resources.JZI0V4;
            this.ClientSize = new System.Drawing.Size(1041, 533);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.LAUNCH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Crazy Client";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton LAUNCH;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Button exit;
    }
}

