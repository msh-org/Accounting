namespace Store_Acconting.Forms.Buy
{
    partial class frmBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvGoostList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmsGoodsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddToInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalyGoods = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFinalyPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgvList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoostList)).BeginInit();
            this.cmsGoodsList.SuspendLayout();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsDgvList.SuspendLayout();
            this.group1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbers)).BeginInit();
            this.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(945, 70);
            this.pnlHeader.TabIndex = 1;
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(408, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "سیستم حسابداری فروشگاه";
            // 
            // dgvGoostList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGoostList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoostList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoostList.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoostList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoostList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoostList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoostList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameKala,
            this.PurchasePrice,
            this.SalesPrice,
            this.Numbers,
            this.InsertDate,
            this.company});
            this.dgvGoostList.ContextMenuStrip = this.cmsGoodsList;
            this.dgvGoostList.DoubleBuffered = true;
            this.dgvGoostList.EnableHeadersVisualStyles = false;
            this.dgvGoostList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvGoostList.HeaderForeColor = System.Drawing.Color.Maroon;
            this.dgvGoostList.Location = new System.Drawing.Point(485, 232);
            this.dgvGoostList.Name = "dgvGoostList";
            this.dgvGoostList.ReadOnly = true;
            this.dgvGoostList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvGoostList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGoostList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoostList.Size = new System.Drawing.Size(448, 269);
            this.dgvGoostList.TabIndex = 9;
            this.dgvGoostList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoostList_CellClick);
            this.dgvGoostList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoostList_CellDoubleClick);
            // 
            // cmsGoodsList
            // 
            this.cmsGoodsList.BackColor = System.Drawing.Color.Green;
            this.cmsGoodsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddToInvoice});
            this.cmsGoodsList.Name = "cmsGoodsList";
            this.cmsGoodsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGoodsList.Size = new System.Drawing.Size(179, 32);
            // 
            // cmsAddToInvoice
            // 
            this.cmsAddToInvoice.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.cmsAddToInvoice.ForeColor = System.Drawing.Color.White;
            this.cmsAddToInvoice.Name = "cmsAddToInvoice";
            this.cmsAddToInvoice.Size = new System.Drawing.Size(178, 28);
            this.cmsAddToInvoice.Text = "افزودن به سبد خرید";
            this.cmsAddToInvoice.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cmsAddToInvoice.Click += new System.EventHandler(this.cmsAddToInvoice_Click);
            // 
            // group2
            // 
            this.group2.Controls.Add(this.label9);
            this.group2.Controls.Add(this.lblDiscount);
            this.group2.Controls.Add(this.label11);
            this.group2.Controls.Add(this.txtDiscount);
            this.group2.Controls.Add(this.label1);
            this.group2.Controls.Add(this.btnDelete);
            this.group2.Controls.Add(this.label8);
            this.group2.Controls.Add(this.btnFinalyGoods);
            this.group2.Controls.Add(this.label7);
            this.group2.Controls.Add(this.lblFinalyPrice);
            this.group2.Controls.Add(this.label6);
            this.group2.Controls.Add(this.dgvList);
            this.group2.Enabled = false;
            this.group2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic);
            this.group2.Location = new System.Drawing.Point(7, 76);
            this.group2.Name = "group2";
            this.group2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.group2.Size = new System.Drawing.Size(465, 432);
            this.group2.TabIndex = 22;
            this.group2.TabStop = false;
            this.group2.Text = "فاکتور";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(389, 67);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "با تخفیف:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiscount.Location = new System.Drawing.Point(256, 67);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDiscount.Size = new System.Drawing.Size(18, 24);
            this.lblDiscount.TabIndex = 38;
            this.lblDiscount.Text = "0";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(225, 67);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(32, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "ريال";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(47, 61);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(91, 30);
            this.txtDiscount.TabIndex = 36;
            this.txtDiscount.ValueChanged += new System.EventHandler(this.TxtDiscount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "درصد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 34);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(144, 64);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "تخفیف:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalyGoods
            // 
            this.btnFinalyGoods.BackColor = System.Drawing.Color.Green;
            this.btnFinalyGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalyGoods.ForeColor = System.Drawing.Color.White;
            this.btnFinalyGoods.Location = new System.Drawing.Point(105, 21);
            this.btnFinalyGoods.Name = "btnFinalyGoods";
            this.btnFinalyGoods.Size = new System.Drawing.Size(114, 34);
            this.btnFinalyGoods.TabIndex = 34;
            this.btnFinalyGoods.Text = "تکمیل خرید";
            this.btnFinalyGoods.UseVisualStyleBackColor = false;
            this.btnFinalyGoods.Click += new System.EventHandler(this.BtnFinalyGoods_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(392, 31);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "مبلغ کل:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalyPrice
            // 
            this.lblFinalyPrice.AutoSize = true;
            this.lblFinalyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalyPrice.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFinalyPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblFinalyPrice.Location = new System.Drawing.Point(256, 31);
            this.lblFinalyPrice.Name = "lblFinalyPrice";
            this.lblFinalyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFinalyPrice.Size = new System.Drawing.Size(18, 24);
            this.lblFinalyPrice.TabIndex = 32;
            this.lblFinalyPrice.Text = "0";
            this.lblFinalyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(225, 31);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "ريال";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.clmNumber,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.dgvList.ContextMenuStrip = this.cmsDgvList;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.DoubleBuffered = true;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvList.HeaderForeColor = System.Drawing.Color.Maroon;
            this.dgvList.Location = new System.Drawing.Point(6, 95);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(443, 329);
            this.dgvList.TabIndex = 28;
            this.dgvList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvList_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام کالا";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmNumber
            // 
            this.clmNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNumber.DataPropertyName = "Numbers";
            this.clmNumber.HeaderText = "تعداد ";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SalesPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "قیمت واحد";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "finalyPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "قیمت کل";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // cmsDgvList
            // 
            this.cmsDgvList.BackColor = System.Drawing.Color.Red;
            this.cmsDgvList.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmsDgvList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteInvoice});
            this.cmsDgvList.Name = "cmsDgvList";
            this.cmsDgvList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsDgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsDgvList.ShowImageMargin = false;
            this.cmsDgvList.Size = new System.Drawing.Size(149, 32);
            // 
            // cmsDeleteInvoice
            // 
            this.cmsDeleteInvoice.ForeColor = System.Drawing.SystemColors.Control;
            this.cmsDeleteInvoice.Name = "cmsDeleteInvoice";
            this.cmsDeleteInvoice.Size = new System.Drawing.Size(148, 28);
            this.cmsDeleteInvoice.Text = "حذف از سبد خرید";
            this.cmsDeleteInvoice.Click += new System.EventHandler(this.cmsDeleteInvoice_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.panel2);
            this.group1.Controls.Add(this.panel1);
            this.group1.Controls.Add(this.btnCancel);
            this.group1.Controls.Add(this.btnSubmit);
            this.group1.Controls.Add(this.label5);
            this.group1.Controls.Add(this.txtNumbers);
            this.group1.Controls.Add(this.label4);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Enabled = false;
            this.group1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic);
            this.group1.Location = new System.Drawing.Point(485, 76);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(448, 109);
            this.group1.TabIndex = 23;
            this.group1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Location = new System.Drawing.Point(29, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 30);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Location = new System.Drawing.Point(179, 30);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(215, 30);
            this.panel1.TabIndex = 34;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblGoodsName.ForeColor = System.Drawing.Color.Maroon;
            this.lblGoodsName.Location = new System.Drawing.Point(5, 9);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoodsName.Size = new System.Drawing.Size(16, 13);
            this.lblGoodsName.TabIndex = 25;
            this.lblGoodsName.Text = "...";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(6, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "برداشتن";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(105, 61);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 34);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "افزودن به سبد خرید";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(0, 34);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "ريال";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(313, 64);
            this.txtNumbers.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.txtNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumbers.Size = new System.Drawing.Size(91, 30);
            this.txtNumbers.TabIndex = 26;
            this.txtNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumbers.ValueChanged += new System.EventHandler(this.txtNumbers_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(277, 67);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "عدد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(410, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "تعداد:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(400, 34);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "نام کالا:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.Location = new System.Drawing.Point(485, 191);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(370, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextPlaceholder = "";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(861, 196);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "جستجو کالا:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameKala
            // 
            this.NameKala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameKala.DataPropertyName = "Name";
            this.NameKala.HeaderText = "نام کالا";
            this.NameKala.Name = "NameKala";
            this.NameKala.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "قیمت خرید";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Visible = false;
            // 
            // SalesPrice
            // 
            this.SalesPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "قیمت";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // Numbers
            // 
            this.Numbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numbers.DataPropertyName = "Numbers";
            this.Numbers.HeaderText = "تعداد";
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            // 
            // InsertDate
            // 
            this.InsertDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InsertDate.DataPropertyName = "InsertDate";
            this.InsertDate.HeaderText = "بروزرسانی";
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.ReadOnly = true;
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.DataPropertyName = "company";
            this.company.HeaderText = "شرکت";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrice.Location = new System.Drawing.Point(6, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(19, 24);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "...";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 512);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.dgvGoostList);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuy";
            this.Text = "frmBuy";
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoostList)).EndInit();
            this.cmsGoodsList.ResumeLayout(false);
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsDgvList.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvGoostList;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinalyPrice;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvList;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtNumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFinalyGoods;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip cmsDgvList;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteInvoice;
        private System.Windows.Forms.ContextMenuStrip cmsGoodsList;
        protected System.Windows.Forms.ToolStripMenuItem cmsAddToInvoice;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKala;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.Label lblPrice;
    }
}