namespace Store_Acconting.Forms.Accont
{
    partial class frmAcconting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcconting));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.dgvList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOrderByDate = new System.Windows.Forms.RadioButton();
            this.radOrderByName = new System.Windows.Forms.RadioButton();
            this.radOrderByInvoiceNumber = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSearchByName = new System.Windows.Forms.RadioButton();
            this.radSearchByInvoiceNumber = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picPrint = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnFilter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.printDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFinalyPrice = new System.Windows.Forms.Label();
            this.txtFirtPrice = new System.Windows.Forms.TextBox();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column3,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Column2});
            this.dgvList.DoubleBuffered = true;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvList.HeaderForeColor = System.Drawing.Color.Maroon;
            this.dgvList.Location = new System.Drawing.Point(12, 75);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(826, 439);
            this.dgvList.TabIndex = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InvoiceNumber";
            this.Column3.HeaderText = "شماره فاکتور";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام کالا";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Date";
            this.Column1.HeaderText = "تاریخ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "قیمت";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn4.HeaderText = "تخفیف";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiscountPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "قیمت با تخفیف";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Condition";
            this.Column2.HeaderText = "وضعیت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(844, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 476);
            this.panel1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOrderByDate);
            this.groupBox1.Controls.Add(this.radOrderByName);
            this.groupBox1.Controls.Add(this.radOrderByInvoiceNumber);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(851, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 133);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مرتب سازی";
            // 
            // radOrderByDate
            // 
            this.radOrderByDate.AutoSize = true;
            this.radOrderByDate.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Italic);
            this.radOrderByDate.Location = new System.Drawing.Point(12, 61);
            this.radOrderByDate.Name = "radOrderByDate";
            this.radOrderByDate.Size = new System.Drawing.Size(111, 25);
            this.radOrderByDate.TabIndex = 2;
            this.radOrderByDate.Text = "بر اساس تاریخ خرید";
            this.radOrderByDate.UseVisualStyleBackColor = true;
            this.radOrderByDate.CheckedChanged += new System.EventHandler(this.radOrderByDate_CheckedChanged);
            // 
            // radOrderByName
            // 
            this.radOrderByName.AutoSize = true;
            this.radOrderByName.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Italic);
            this.radOrderByName.Location = new System.Drawing.Point(29, 92);
            this.radOrderByName.Name = "radOrderByName";
            this.radOrderByName.Size = new System.Drawing.Size(94, 25);
            this.radOrderByName.TabIndex = 1;
            this.radOrderByName.Text = "بر اساس نام کالا";
            this.radOrderByName.UseVisualStyleBackColor = true;
            this.radOrderByName.CheckedChanged += new System.EventHandler(this.radOrderByName_CheckedChanged);
            // 
            // radOrderByInvoiceNumber
            // 
            this.radOrderByInvoiceNumber.AutoSize = true;
            this.radOrderByInvoiceNumber.Checked = true;
            this.radOrderByInvoiceNumber.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Italic);
            this.radOrderByInvoiceNumber.Location = new System.Drawing.Point(6, 30);
            this.radOrderByInvoiceNumber.Name = "radOrderByInvoiceNumber";
            this.radOrderByInvoiceNumber.Size = new System.Drawing.Size(117, 25);
            this.radOrderByInvoiceNumber.TabIndex = 0;
            this.radOrderByInvoiceNumber.TabStop = true;
            this.radOrderByInvoiceNumber.Text = "بر اساس شماره فاکتور";
            this.radOrderByInvoiceNumber.UseVisualStyleBackColor = true;
            this.radOrderByInvoiceNumber.CheckedChanged += new System.EventHandler(this.radOrderByInvoiceNumber_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(892, 215);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "جستجو:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSearchByName);
            this.groupBox2.Controls.Add(this.radSearchByInvoiceNumber);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(851, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 94);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // radSearchByName
            // 
            this.radSearchByName.AutoSize = true;
            this.radSearchByName.Checked = true;
            this.radSearchByName.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Italic);
            this.radSearchByName.Location = new System.Drawing.Point(29, 29);
            this.radSearchByName.Name = "radSearchByName";
            this.radSearchByName.Size = new System.Drawing.Size(94, 25);
            this.radSearchByName.TabIndex = 1;
            this.radSearchByName.TabStop = true;
            this.radSearchByName.Text = "بر اساس نام کالا";
            this.radSearchByName.UseVisualStyleBackColor = true;
            // 
            // radSearchByInvoiceNumber
            // 
            this.radSearchByInvoiceNumber.AutoSize = true;
            this.radSearchByInvoiceNumber.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Italic);
            this.radSearchByInvoiceNumber.Location = new System.Drawing.Point(6, 59);
            this.radSearchByInvoiceNumber.Name = "radSearchByInvoiceNumber";
            this.radSearchByInvoiceNumber.Size = new System.Drawing.Size(117, 25);
            this.radSearchByInvoiceNumber.TabIndex = 0;
            this.radSearchByInvoiceNumber.Text = "بر اساس شماره فاکتور";
            this.radSearchByInvoiceNumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(892, 380);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "از قیمت:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(892, 445);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "تا قیمت:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.picPrint);
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
            this.pnlHeader.Size = new System.Drawing.Size(991, 70);
            this.pnlHeader.TabIndex = 31;
            // 
            // picPrint
            // 
            this.picPrint.BackColor = System.Drawing.Color.Transparent;
            this.picPrint.Image = global::Store_Acconting.Properties.Resources._1371476276_Print;
            this.picPrint.Location = new System.Drawing.Point(12, 10);
            this.picPrint.Name = "picPrint";
            this.picPrint.Size = new System.Drawing.Size(48, 48);
            this.picPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrint.TabIndex = 9;
            this.picPrint.TabStop = false;
            this.picPrint.Click += new System.EventHandler(this.picPrint_Click);
            this.picPrint.MouseLeave += new System.EventHandler(this.picPrint_MouseLeave);
            this.picPrint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPrint_MouseMove);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Store_Acconting.Properties.Resources.Close_Window__2_48px;
            this.picClose.Location = new System.Drawing.Point(944, 17);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(434, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "صفحه حسابداری";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.ButtonText = "ثبت فیلتر قیمت";
            this.btnFilter.ButtonTextMarginLeft = 0;
            this.btnFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnFilter.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnFilter.DisabledForecolor = System.Drawing.Color.White;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.IconPadding = 10;
            this.btnFilter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.IdleBorderColor = System.Drawing.Color.Green;
            this.btnFilter.IdleBorderRadius = 1;
            this.btnFilter.IdleBorderThickness = 0;
            this.btnFilter.IdleFillColor = System.Drawing.Color.Green;
            this.btnFilter.IdleIconLeftImage = null;
            this.btnFilter.IdleIconRightImage = null;
            this.btnFilter.Location = new System.Drawing.Point(861, 513);
            this.btnFilter.Name = "btnFilter";
            stateProperties1.BorderColor = System.Drawing.Color.DarkGreen;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkGreen;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnFilter.onHoverState = stateProperties1;
            this.btnFilter.Size = new System.Drawing.Size(110, 44);
            this.btnFilter.TabIndex = 42;
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(851, 242);
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
            this.txtSearch.Size = new System.Drawing.Size(128, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextPlaceholder = "";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange_1);
            // 
            // printDialog
            // 
            this.printDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printDialog.Enabled = true;
            this.printDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printDialog.Icon")));
            this.printDialog.Name = "printDialog";
            this.printDialog.Visible = false;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "aa34fb62c9854654b993870f634f3b91";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFinalyPrice, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 521);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 36);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // lblFinalyPrice
            // 
            this.lblFinalyPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFinalyPrice.AutoSize = true;
            this.lblFinalyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalyPrice.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFinalyPrice.ForeColor = System.Drawing.Color.Red;
            this.lblFinalyPrice.Location = new System.Drawing.Point(3, 5);
            this.lblFinalyPrice.Name = "lblFinalyPrice";
            this.lblFinalyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFinalyPrice.Size = new System.Drawing.Size(102, 26);
            this.lblFinalyPrice.TabIndex = 44;
            this.lblFinalyPrice.Text = "قیمت کل: 0 ریال";
            this.lblFinalyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirtPrice
            // 
            this.txtFirtPrice.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirtPrice.Location = new System.Drawing.Point(851, 411);
            this.txtFirtPrice.Name = "txtFirtPrice";
            this.txtFirtPrice.Size = new System.Drawing.Size(128, 31);
            this.txtFirtPrice.TabIndex = 44;
            this.txtFirtPrice.TextChanged += new System.EventHandler(this.txtFirtPrice_TextChanged);
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPrice.Location = new System.Drawing.Point(851, 472);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(128, 31);
            this.txtLastPrice.TabIndex = 44;
            this.txtLastPrice.TextChanged += new System.EventHandler(this.txtFirtPrice_TextChanged);
            // 
            // frmAcconting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 512);
            this.Controls.Add(this.txtLastPrice);
            this.Controls.Add(this.txtFirtPrice);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcconting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAcconting";
            this.Load += new System.EventHandler(this.frmAcconting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvList;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOrderByDate;
        private System.Windows.Forms.RadioButton radOrderByName;
        private System.Windows.Forms.RadioButton radOrderByInvoiceNumber;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSearchByName;
        private System.Windows.Forms.RadioButton radSearchByInvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFilter;
        private System.Windows.Forms.PictureBox picPrint;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PrintPreviewDialog printDialog;
        private Stimulsoft.Report.StiReport stiPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFinalyPrice;
        private System.Windows.Forms.TextBox txtFirtPrice;
        private System.Windows.Forms.TextBox txtLastPrice;
    }
}