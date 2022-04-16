namespace Store_Acconting.Forms.SplashScreen
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblLoadBar = new System.Windows.Forms.Label();
            this.lineLoadBar = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblLoadBar);
            this.bunifuGradientPanel1.Controls.Add(this.lineLoadBar);
            this.bunifuGradientPanel1.Controls.Add(this.lblPleaseWait);
            this.bunifuGradientPanel1.Controls.Add(this.lblAppName);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(300, 174);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lblLoadBar
            // 
            this.lblLoadBar.AutoSize = true;
            this.lblLoadBar.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadBar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadBar.ForeColor = System.Drawing.Color.Blue;
            this.lblLoadBar.Location = new System.Drawing.Point(99, 148);
            this.lblLoadBar.Name = "lblLoadBar";
            this.lblLoadBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoadBar.Size = new System.Drawing.Size(129, 17);
            this.lblLoadBar.TabIndex = 5;
            this.lblLoadBar.Text = "در حال بارگذاری 0%";
            // 
            // lineLoadBar
            // 
            this.lineLoadBar.BackColor = System.Drawing.Color.Transparent;
            this.lineLoadBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineLoadBar.LineThickness = 3;
            this.lineLoadBar.Location = new System.Drawing.Point(0, 118);
            this.lineLoadBar.Name = "lineLoadBar";
            this.lineLoadBar.Size = new System.Drawing.Size(0, 30);
            this.lineLoadBar.TabIndex = 4;
            this.lineLoadBar.Transparency = 255;
            this.lineLoadBar.Vertical = false;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.lblPleaseWait.BackColor = System.Drawing.Color.Transparent;
            this.lblPleaseWait.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPleaseWait.Location = new System.Drawing.Point(96, 100);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPleaseWait.Size = new System.Drawing.Size(98, 17);
            this.lblPleaseWait.TabIndex = 3;
            this.lblPleaseWait.Text = "لطفا منتظر بمانید...";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAppName.Location = new System.Drawing.Point(85, 32);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAppName.Size = new System.Drawing.Size(144, 24);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "سیستم حسابداری فروشگاه";
            // 
            // tmrClose
            // 
            this.tmrClose.Enabled = true;
            this.tmrClose.Interval = 35;
            this.tmrClose.Tick += new System.EventHandler(this.TmrClose_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 174);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSplashScreen_FormClosing);
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblPleaseWait;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.Label lblLoadBar;
        private Bunifu.Framework.UI.BunifuSeparator lineLoadBar;
    }
}