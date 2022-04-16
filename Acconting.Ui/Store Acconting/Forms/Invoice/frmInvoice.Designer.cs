namespace Store_Acconting.Forms.Invoice
{
    partial class frmInvoice
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.dgvInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsInvoice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtSearchGoods = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnDeleteInvoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEditInvoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.cmsInvoice.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameKala,
            this.PurchasePrice,
            this.Numbers,
            this.InsertDate});
            this.dgvInvoice.ContextMenuStrip = this.cmsInvoice;
            this.dgvInvoice.DoubleBuffered = true;
            this.dgvInvoice.EnableHeadersVisualStyles = false;
            this.dgvInvoice.HeaderBgColor = System.Drawing.Color.White;
            this.dgvInvoice.HeaderForeColor = System.Drawing.Color.Maroon;
            this.dgvInvoice.Location = new System.Drawing.Point(12, 126);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(783, 382);
            this.dgvInvoice.TabIndex = 10;
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellDoubleClick);
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
            this.NameKala.DataPropertyName = "NameFamily";
            this.NameKala.HeaderText = "نام مشتری";
            this.NameKala.Name = "NameKala";
            this.NameKala.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchasePrice.DataPropertyName = "Data";
            this.PurchasePrice.HeaderText = "تاریخ";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Numbers
            // 
            this.Numbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numbers.DataPropertyName = "Price";
            this.Numbers.HeaderText = "مبلغ";
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            // 
            // InsertDate
            // 
            this.InsertDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InsertDate.DataPropertyName = "InvoiceNumber";
            this.InsertDate.HeaderText = "شماره فاکتور";
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.ReadOnly = true;
            // 
            // cmsInvoice
            // 
            this.cmsInvoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditInvoice,
            this.cmsDeleteInvoice});
            this.cmsInvoice.Name = "cmsInvoice";
            this.cmsInvoice.Size = new System.Drawing.Size(162, 52);
            // 
            // cmsEditInvoice
            // 
            this.cmsEditInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmsEditInvoice.ForeColor = System.Drawing.Color.White;
            this.cmsEditInvoice.Name = "cmsEditInvoice";
            this.cmsEditInvoice.Size = new System.Drawing.Size(161, 24);
            this.cmsEditInvoice.Text = "ویرایش فاکتور";
            this.cmsEditInvoice.Click += new System.EventHandler(this.cmsEditInvoice_Click);
            // 
            // cmsDeleteInvoice
            // 
            this.cmsDeleteInvoice.BackColor = System.Drawing.Color.Red;
            this.cmsDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.cmsDeleteInvoice.Name = "cmsDeleteInvoice";
            this.cmsDeleteInvoice.Size = new System.Drawing.Size(161, 24);
            this.cmsDeleteInvoice.Text = "حذف فاکتور";
            this.cmsDeleteInvoice.Click += new System.EventHandler(this.cmsDeleteInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(394, 86);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "جستجو:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
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
            this.txtSearchGoods.Size = new System.Drawing.Size(376, 35);
            this.txtSearchGoods.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearchGoods.TabIndex = 15;
            this.txtSearchGoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchGoods.TextMarginLeft = 5;
            this.txtSearchGoods.TextPlaceholder = "";
            this.txtSearchGoods.UseSystemPasswordChar = false;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteInvoice.BackgroundImage")));
            this.btnDeleteInvoice.ButtonText = "حذف فاکتور";
            this.btnDeleteInvoice.ButtonTextMarginLeft = 0;
            this.btnDeleteInvoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteInvoice.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnDeleteInvoice.DisabledForecolor = System.Drawing.Color.White;
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteInvoice.IconPadding = 10;
            this.btnDeleteInvoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteInvoice.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDeleteInvoice.IdleBorderRadius = 1;
            this.btnDeleteInvoice.IdleBorderThickness = 0;
            this.btnDeleteInvoice.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDeleteInvoice.IdleIconLeftImage = null;
            this.btnDeleteInvoice.IdleIconRightImage = null;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(461, 76);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnDeleteInvoice.onHoverState = stateProperties1;
            this.btnDeleteInvoice.Size = new System.Drawing.Size(163, 44);
            this.btnDeleteInvoice.TabIndex = 14;
            this.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnEditInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditInvoice.BackgroundImage")));
            this.btnEditInvoice.ButtonText = "ویرایش فاکتور";
            this.btnEditInvoice.ButtonTextMarginLeft = 0;
            this.btnEditInvoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditInvoice.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditInvoice.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditInvoice.ForeColor = System.Drawing.Color.White;
            this.btnEditInvoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditInvoice.IconPadding = 10;
            this.btnEditInvoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditInvoice.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditInvoice.IdleBorderRadius = 1;
            this.btnEditInvoice.IdleBorderThickness = 0;
            this.btnEditInvoice.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditInvoice.IdleIconLeftImage = null;
            this.btnEditInvoice.IdleIconRightImage = null;
            this.btnEditInvoice.Location = new System.Drawing.Point(632, 76);
            this.btnEditInvoice.Name = "btnEditInvoice";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnEditInvoice.onHoverState = stateProperties2;
            this.btnEditInvoice.Size = new System.Drawing.Size(163, 44);
            this.btnEditInvoice.TabIndex = 13;
            this.btnEditInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
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
            this.pnlHeader.Size = new System.Drawing.Size(807, 70);
            this.pnlHeader.TabIndex = 11;
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.Color.Transparent;
            this.picHide.Image = global::Store_Acconting.Properties.Resources.Minimize_Window_2_48px;
            this.picHide.Location = new System.Drawing.Point(719, 17);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(35, 35);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 11;
            this.picHide.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Store_Acconting.Properties.Resources.Close_Window__2_48px;
            this.picClose.Location = new System.Drawing.Point(760, 17);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Narm", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(382, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "فاکتور ها";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchGoods);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.cmsInvoice.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInvoice;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearchGoods;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteInvoice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditInvoice;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKala;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertDate;
        private System.Windows.Forms.ContextMenuStrip cmsInvoice;
        private System.Windows.Forms.ToolStripMenuItem cmsEditInvoice;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteInvoice;
    }
}