namespace Store_Acconting.Forms.Goods.GoodsList
{
    partial class frmGoodsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsList));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGoostList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgvGoostList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtSearchGoods = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnDeleteGoods = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEditGoods = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddGoods = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLowGoods = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoostList)).BeginInit();
            this.cmsDgvGoostList.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(295, 86);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "جستجو:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGoostList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGoostList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoostList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoostList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGoostList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoostList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvGoostList.ContextMenuStrip = this.cmsDgvGoostList;
            this.dgvGoostList.DoubleBuffered = true;
            this.dgvGoostList.EnableHeadersVisualStyles = false;
            this.dgvGoostList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvGoostList.HeaderForeColor = System.Drawing.Color.Maroon;
            this.dgvGoostList.Location = new System.Drawing.Point(12, 142);
            this.dgvGoostList.Name = "dgvGoostList";
            this.dgvGoostList.ReadOnly = true;
            this.dgvGoostList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvGoostList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGoostList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoostList.Size = new System.Drawing.Size(684, 268);
            this.dgvGoostList.TabIndex = 8;
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
            // 
            // SalesPrice
            // 
            this.SalesPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "قیمت فروش";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // Numbers
            // 
            this.Numbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numbers.DataPropertyName = "Numbers";
            this.Numbers.HeaderText = "تعداد موجود";
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
            // cmsDgvGoostList
            // 
            this.cmsDgvGoostList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsDelete});
            this.cmsDgvGoostList.Name = "cmsDgvGoostList";
            this.cmsDgvGoostList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsDgvGoostList.Size = new System.Drawing.Size(132, 60);
            // 
            // cmsEdit
            // 
            this.cmsEdit.BackColor = System.Drawing.Color.Teal;
            this.cmsEdit.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.cmsEdit.ForeColor = System.Drawing.Color.White;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(131, 28);
            this.cmsEdit.Text = "ویرایش کالا";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.BackColor = System.Drawing.Color.Red;
            this.cmsDelete.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.cmsDelete.ForeColor = System.Drawing.Color.White;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(131, 28);
            this.cmsDelete.Text = "حذف کالا";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 126);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(684, 10);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.pnlHeader.Size = new System.Drawing.Size(708, 70);
            this.pnlHeader.TabIndex = 2;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Store_Acconting.Properties.Resources.Close_Window__2_48px;
            this.picClose.Location = new System.Drawing.Point(661, 18);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 9;
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
            this.lblTitle.Location = new System.Drawing.Point(319, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 26);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "لیست کالا ها";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // txtSearchGoods
            // 
            this.txtSearchGoods.AcceptsReturn = false;
            this.txtSearchGoods.AcceptsTab = false;
            this.txtSearchGoods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchGoods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchGoods.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchGoods.BackgroundImage")));
            this.txtSearchGoods.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtSearchGoods.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearchGoods.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtSearchGoods.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtSearchGoods.BorderRadius = 1;
            this.txtSearchGoods.BorderThickness = 2;
            this.txtSearchGoods.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchGoods.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGoods.DefaultText = "";
            this.txtSearchGoods.FillColor = System.Drawing.Color.White;
            this.txtSearchGoods.HideSelection = true;
            this.txtSearchGoods.IconLeft = null;
            this.txtSearchGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearchGoods.IconPadding = 10;
            this.txtSearchGoods.IconRight = null;
            this.txtSearchGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearchGoods.Location = new System.Drawing.Point(12, 81);
            this.txtSearchGoods.MaxLength = 32767;
            this.txtSearchGoods.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearchGoods.Modified = false;
            this.txtSearchGoods.Name = "txtSearchGoods";
            this.txtSearchGoods.PasswordChar = '\0';
            this.txtSearchGoods.ReadOnly = false;
            this.txtSearchGoods.SelectedText = "";
            this.txtSearchGoods.SelectionLength = 0;
            this.txtSearchGoods.SelectionStart = 0;
            this.txtSearchGoods.ShortcutsEnabled = true;
            this.txtSearchGoods.Size = new System.Drawing.Size(277, 35);
            this.txtSearchGoods.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearchGoods.TabIndex = 6;
            this.txtSearchGoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchGoods.TextMarginLeft = 5;
            this.txtSearchGoods.TextPlaceholder = "";
            this.txtSearchGoods.UseSystemPasswordChar = false;
            this.txtSearchGoods.TextChange += new System.EventHandler(this.TxtSearchGoods_TextChange);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGoods.BackgroundImage")));
            this.btnDeleteGoods.ButtonText = "حذف کالا";
            this.btnDeleteGoods.ButtonTextMarginLeft = 0;
            this.btnDeleteGoods.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteGoods.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnDeleteGoods.DisabledForecolor = System.Drawing.Color.White;
            this.btnDeleteGoods.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteGoods.IconPadding = 10;
            this.btnDeleteGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteGoods.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDeleteGoods.IdleBorderRadius = 1;
            this.btnDeleteGoods.IdleBorderThickness = 0;
            this.btnDeleteGoods.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDeleteGoods.IdleIconLeftImage = null;
            this.btnDeleteGoods.IdleIconRightImage = null;
            this.btnDeleteGoods.Location = new System.Drawing.Point(438, 76);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnDeleteGoods.onHoverState = stateProperties1;
            this.btnDeleteGoods.Size = new System.Drawing.Size(82, 44);
            this.btnDeleteGoods.TabIndex = 5;
            this.btnDeleteGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteGoods.Click += new System.EventHandler(this.BtnDeleteGoods_Click);
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.BackColor = System.Drawing.Color.Transparent;
            this.btnEditGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditGoods.BackgroundImage")));
            this.btnEditGoods.ButtonText = "ویرایش کالا";
            this.btnEditGoods.ButtonTextMarginLeft = 0;
            this.btnEditGoods.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditGoods.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditGoods.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditGoods.ForeColor = System.Drawing.Color.White;
            this.btnEditGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditGoods.IconPadding = 10;
            this.btnEditGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditGoods.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditGoods.IdleBorderRadius = 1;
            this.btnEditGoods.IdleBorderThickness = 0;
            this.btnEditGoods.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditGoods.IdleIconLeftImage = null;
            this.btnEditGoods.IdleIconRightImage = null;
            this.btnEditGoods.Location = new System.Drawing.Point(526, 76);
            this.btnEditGoods.Name = "btnEditGoods";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnEditGoods.onHoverState = stateProperties2;
            this.btnEditGoods.Size = new System.Drawing.Size(82, 44);
            this.btnEditGoods.TabIndex = 4;
            this.btnEditGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditGoods.Click += new System.EventHandler(this.BtnEditGoods_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGoods.BackgroundImage")));
            this.btnAddGoods.ButtonText = "افزودن کالا";
            this.btnAddGoods.ButtonTextMarginLeft = 0;
            this.btnAddGoods.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddGoods.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddGoods.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddGoods.ForeColor = System.Drawing.Color.White;
            this.btnAddGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddGoods.IconPadding = 10;
            this.btnAddGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddGoods.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddGoods.IdleBorderRadius = 1;
            this.btnAddGoods.IdleBorderThickness = 0;
            this.btnAddGoods.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddGoods.IdleIconLeftImage = null;
            this.btnAddGoods.IdleIconRightImage = null;
            this.btnAddGoods.Location = new System.Drawing.Point(614, 76);
            this.btnAddGoods.Name = "btnAddGoods";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnAddGoods.onHoverState = stateProperties3;
            this.btnAddGoods.Size = new System.Drawing.Size(82, 44);
            this.btnAddGoods.TabIndex = 3;
            this.btnAddGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGoods.Click += new System.EventHandler(this.BtnAddGoods_Click);
            // 
            // btnLowGoods
            // 
            this.btnLowGoods.BackColor = System.Drawing.Color.Transparent;
            this.btnLowGoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLowGoods.BackgroundImage")));
            this.btnLowGoods.ButtonText = "آمار کالا ها";
            this.btnLowGoods.ButtonTextMarginLeft = 0;
            this.btnLowGoods.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLowGoods.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnLowGoods.DisabledForecolor = System.Drawing.Color.White;
            this.btnLowGoods.ForeColor = System.Drawing.Color.White;
            this.btnLowGoods.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLowGoods.IconPadding = 10;
            this.btnLowGoods.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLowGoods.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLowGoods.IdleBorderRadius = 1;
            this.btnLowGoods.IdleBorderThickness = 0;
            this.btnLowGoods.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLowGoods.IdleIconLeftImage = null;
            this.btnLowGoods.IdleIconRightImage = null;
            this.btnLowGoods.Location = new System.Drawing.Point(350, 76);
            this.btnLowGoods.Name = "btnLowGoods";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnLowGoods.onHoverState = stateProperties4;
            this.btnLowGoods.Size = new System.Drawing.Size(82, 44);
            this.btnLowGoods.TabIndex = 10;
            this.btnLowGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLowGoods.Click += new System.EventHandler(this.btnLowGoods_Click);
            // 
            // frmGoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.btnLowGoods);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dgvGoostList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchGoods);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnEditGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoodsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGoodsList";
            this.Load += new System.EventHandler(this.FrmGoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoostList)).EndInit();
            this.cmsDgvGoostList.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddGoods;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditGoods;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteGoods;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearchGoods;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvGoostList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKala;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.ContextMenuStrip cmsDgvGoostList;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLowGoods;
    }
}