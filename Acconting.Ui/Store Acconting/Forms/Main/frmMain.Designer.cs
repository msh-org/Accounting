namespace Store_Acconting.Forms.Main
{
    partial class frmMain
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnInvoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAcconting = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGoods = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBuy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlContent = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picContactUs = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactUs)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.TmrDateTime_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 21;
            this.bunifuElipse2.TargetControl = this.pnlMenu;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.btnInvoice);
            this.pnlMenu.Controls.Add(this.btnAcconting);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnGoods);
            this.pnlMenu.Controls.Add(this.btnBuy);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.GradientBottomLeft = System.Drawing.Color.MediumSlateBlue;
            this.pnlMenu.GradientBottomRight = System.Drawing.Color.MediumSlateBlue;
            this.pnlMenu.GradientTopLeft = System.Drawing.Color.Aqua;
            this.pnlMenu.GradientTopRight = System.Drawing.Color.MediumSlateBlue;
            this.pnlMenu.Location = new System.Drawing.Point(813, 70);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Quality = 10;
            this.pnlMenu.Size = new System.Drawing.Size(137, 426);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInvoice.BackgroundImage")));
            this.btnInvoice.ButtonText = "فاکتور ها";
            this.btnInvoice.ButtonTextMarginLeft = 0;
            this.btnInvoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnInvoice.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnInvoice.DisabledForecolor = System.Drawing.Color.White;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInvoice.IconPadding = 10;
            this.btnInvoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInvoice.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnInvoice.IdleBorderRadius = 1;
            this.btnInvoice.IdleBorderThickness = 0;
            this.btnInvoice.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnInvoice.IdleIconLeftImage = null;
            this.btnInvoice.IdleIconRightImage = null;
            this.btnInvoice.Location = new System.Drawing.Point(13, 211);
            this.btnInvoice.Name = "btnInvoice";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnInvoice.onHoverState = stateProperties1;
            this.btnInvoice.Size = new System.Drawing.Size(110, 60);
            this.btnInvoice.TabIndex = 7;
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnAcconting
            // 
            this.btnAcconting.BackColor = System.Drawing.Color.Transparent;
            this.btnAcconting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcconting.BackgroundImage")));
            this.btnAcconting.ButtonText = "حسابداری";
            this.btnAcconting.ButtonTextMarginLeft = 0;
            this.btnAcconting.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAcconting.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAcconting.DisabledForecolor = System.Drawing.Color.White;
            this.btnAcconting.ForeColor = System.Drawing.Color.White;
            this.btnAcconting.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAcconting.IconPadding = 10;
            this.btnAcconting.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAcconting.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAcconting.IdleBorderRadius = 1;
            this.btnAcconting.IdleBorderThickness = 0;
            this.btnAcconting.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAcconting.IdleIconLeftImage = null;
            this.btnAcconting.IdleIconRightImage = null;
            this.btnAcconting.Location = new System.Drawing.Point(13, 145);
            this.btnAcconting.Name = "btnAcconting";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAcconting.onHoverState = stateProperties2;
            this.btnAcconting.Size = new System.Drawing.Size(110, 60);
            this.btnAcconting.TabIndex = 6;
            this.btnAcconting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcconting.Click += new System.EventHandler(this.btnAcconting_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "خروج";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExit.DisabledForecolor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExit.IdleBorderRadius = 1;
            this.btnExit.IdleBorderThickness = 0;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.Location = new System.Drawing.Point(13, 343);
            this.btnExit.Name = "btnExit";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnExit.onHoverState = stateProperties3;
            this.btnExit.Size = new System.Drawing.Size(110, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.ButtonText = "تنظیمات";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSettings.DisabledForecolor = System.Drawing.Color.White;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconPadding = 10;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSettings.IdleBorderRadius = 1;
            this.btnSettings.IdleBorderThickness = 0;
            this.btnSettings.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSettings.IdleIconLeftImage = null;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.Location = new System.Drawing.Point(13, 277);
            this.btnSettings.Name = "btnSettings";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnSettings.onHoverState = stateProperties4;
            this.btnSettings.Size = new System.Drawing.Size(110, 60);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.BackColor = System.Drawing.Color.Transparent;
            this.btnGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoods.BackgroundImage")));
            this.btnGoods.ButtonText = "کالا";
            this.btnGoods.ButtonTextMarginLeft = 0;
            this.btnGoods.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnGoods.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnGoods.DisabledForecolor = System.Drawing.Color.White;
            this.btnGoods.ForeColor = System.Drawing.Color.White;
            this.btnGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGoods.IconPadding = 10;
            this.btnGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGoods.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGoods.IdleBorderRadius = 1;
            this.btnGoods.IdleBorderThickness = 0;
            this.btnGoods.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGoods.IdleIconLeftImage = null;
            this.btnGoods.IdleIconRightImage = null;
            this.btnGoods.Location = new System.Drawing.Point(14, 79);
            this.btnGoods.Name = "btnGoods";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnGoods.onHoverState = stateProperties5;
            this.btnGoods.Size = new System.Drawing.Size(110, 60);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoods.Click += new System.EventHandler(this.BtnGoods_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.ButtonText = "خرید";
            this.btnBuy.ButtonTextMarginLeft = 0;
            this.btnBuy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnBuy.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnBuy.DisabledForecolor = System.Drawing.Color.White;
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IconPadding = 10;
            this.btnBuy.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBuy.IdleBorderRadius = 1;
            this.btnBuy.IdleBorderThickness = 0;
            this.btnBuy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBuy.IdleIconLeftImage = null;
            this.btnBuy.IdleIconRightImage = null;
            this.btnBuy.Location = new System.Drawing.Point(13, 13);
            this.btnBuy.Name = "btnBuy";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnBuy.onHoverState = stateProperties6;
            this.btnBuy.Size = new System.Drawing.Size(110, 60);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.chart1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlContent.GradientBottomRight = System.Drawing.Color.White;
            this.pnlContent.GradientTopLeft = System.Drawing.Color.White;
            this.pnlContent.GradientTopRight = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Quality = 10;
            this.pnlContent.Size = new System.Drawing.Size(813, 426);
            this.pnlContent.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.Teal;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "آمار فروش";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(813, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Controls.Add(this.picContactUs);
            this.pnlFooter.Controls.Add(this.lblDate);
            this.pnlFooter.Controls.Add(this.lblTime);
            this.pnlFooter.Controls.Add(this.bunifuSeparator1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlFooter.GradientBottomRight = System.Drawing.Color.White;
            this.pnlFooter.GradientTopLeft = System.Drawing.Color.White;
            this.pnlFooter.GradientTopRight = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(0, 496);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Quality = 10;
            this.pnlFooter.Size = new System.Drawing.Size(950, 48);
            this.pnlFooter.TabIndex = 2;
            // 
            // picContactUs
            // 
            this.picContactUs.BackColor = System.Drawing.Color.White;
            this.picContactUs.Image = global::Store_Acconting.Properties.Resources.contact;
            this.picContactUs.Location = new System.Drawing.Point(902, 6);
            this.picContactUs.Name = "picContactUs";
            this.picContactUs.Size = new System.Drawing.Size(35, 35);
            this.picContactUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContactUs.TabIndex = 7;
            this.picContactUs.TabStop = false;
            this.picContactUs.Click += new System.EventHandler(this.PicContactUs_Click);
            this.picContactUs.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            this.picContactUs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicClose_MouseMove);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(12, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 16);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "٠٠٠٠/٠٠/٠٠";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTime.Location = new System.Drawing.Point(92, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(64, 16);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "٠٠:٠٠:٠٠";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, -5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(813, 10);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.picHide);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlHeader.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Quality = 10;
            this.pnlHeader.Size = new System.Drawing.Size(950, 70);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseUp);
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.Color.Transparent;
            this.picHide.Image = global::Store_Acconting.Properties.Resources.Minimize_Window_2_48px;
            this.picHide.Location = new System.Drawing.Point(860, 17);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(35, 35);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 9;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.PicHide_Click);
            this.picHide.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            this.picHide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicClose_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Store_Acconting.Properties.Resources.Close_Window__2_48px;
            this.picClose.Location = new System.Drawing.Point(901, 17);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicClose_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(397, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "سیستم حسابداری فروشگاه";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseUp);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 5000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactUs)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlHeader;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlFooter;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlContent;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGoods;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuy;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picContactUs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picHide;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInvoice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAcconting;
        private System.Windows.Forms.Timer tmr;
    }
}