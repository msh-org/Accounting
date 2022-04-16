using Acconting.DataLayer;
using Acconting.DataLayer.Repositories;
using Acconting.DataLayer.Services;
using Acconting.utility;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Buy
{
    public partial class frmBuy : Form
    {
        //---------------------------------------------
        IGoodsRepository goods = new GoodsRepository();
        IBuyRepository buy = new BuyRepository();
        IInvoiceRepository invoice = new InvoiceRepository();
        //---------------------------------------------

        //---------------------------------------------
        private int index = -1;
        //---------------------------------------------

        public frmBuy()
        {
            InitializeComponent();
        }

        private void FrmBuy_Load(object sender, EventArgs e)
        {
            refreshDate();
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvList.BackgroundColor = dgvGoostList.BackgroundColor = Properties.Settings.Default.BackColor;
        }

        private void refreshDate()
        {
            dgvGoostList.DataSource = goods.GetAllGoods().Where(p => p.Numbers > 0).ToList();
        }

        private void DgvGoostList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSubmit_Click(null, null);
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtNumbers_ValueChanged(object sender, EventArgs e)
        {
            lblPrice.Text = (Convert.ToInt32(dgvGoostList.SelectedCells[3].Value) * (int)txtNumbers.Value).ToString("#,#"); ;
        }

        private void DgvGoostList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblGoodsName.Text = dgvGoostList.SelectedCells[1].Value.ToString();
            string price = dgvGoostList.SelectedCells[3].Value.ToString();
            lblPrice.Text = Convert.ToInt32(price.Replace(",", "")).ToString("#,#");
            lblGoodsName.Location = new System.Drawing.Point(panel1.Width - lblGoodsName.Width, 9);
            txtNumbers.Value = 1;
            group1.Enabled = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvList.Rows[0].Clone();
            row.Cells[0].Value = lblGoodsName.Text;
            row.Cells[1].Value = Text = txtNumbers.Value.ToString("#,#");
            string price = dgvGoostList.SelectedCells[3].Value.ToString();
            row.Cells[2].Value = Convert.ToInt32(price.Replace(",", "")).ToString("#,#");
            row.Cells[3].Value = (Convert.ToInt32(lblPrice.Text.Replace(",", string.Empty)) * txtNumbers.Value).ToString("#,#");
            row.Cells[4].Value = dgvGoostList.SelectedCells[0].Value;
            dgvList.Rows.Add(row);
            lblFinalyPrice.Text = (Convert.ToInt32(lblFinalyPrice.Text.Replace(",", string.Empty)) + (Convert.ToInt32(lblPrice.Text.Replace(",", string.Empty)) * txtNumbers.Value)).ToString("#,#");
            txtNumbers.Value = 1;
            BtnCancel_Click(null, null);
            group2.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            lblGoodsName.Text = "...";
            lblPrice.Text = "...";
            txtNumbers.Value = 1;
            group1.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (index != -1)
            {
                try
                {
                    lblFinalyPrice.Text = ((Convert.ToInt32(lblFinalyPrice.Text.Replace(",", string.Empty)) - (Convert.ToInt32(dgvList.Rows[index].Cells[3].Value.ToString().Replace(",", string.Empty))))).ToString("#,#");
                    dgvList.Rows.RemoveAt(index);

                    if (dgvList.Rows == null)
                    {
                        lblFinalyPrice.Text = "0";
                        group2.Enabled = false;
                    }

                }
                catch { }

            }
            else
            {
                MessageBox.Show("کالایی برای حذف انتخاب نشده است");
            }
        }

        private void PicHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFinalyGoods_Click(object sender, EventArgs e)
        {
            Buys p = new Buys();
            int count = dgvList.RowCount;
            int invoiceNumber = buy.getLastInvoiceNumber() + 1;

            for (int i = 0; i < count - 1; i++)
            {
                if (dgvList.Rows.Count >= 0)
                {
                    //---------------------------------------------
                    Thread.Sleep(30);
                    int id = Convert.ToInt32(dgvList.Rows[dgvList.Rows.Count - 2].Cells["Column1"].Value.ToString());
                    p.Name = dgvList.Rows[dgvList.Rows.Count - 2].Cells[0].Value.ToString();
                    p.Price = Convert.ToDouble(dgvList.Rows[dgvList.Rows.Count - 2].Cells[3].Value).ToString("#,#");
                    p.Discount = txtDiscount.Value + "%";
                    p.DiscountPrice = ((Convert.ToDouble(dgvList.Rows[dgvList.Rows.Count - 2].Cells[3].Value) / 100) * (100 - Convert.ToDouble(txtDiscount.Value))).ToString("#,#");
                    p.Date = new DateAndTime().PersianDate() + "-" + new DateAndTime().time();
                    p.Condition = "OK";
                    p.InvoiceNumber = invoiceNumber;
                    bool a = buy.InsertBuy(p);
                    //---------------------------------------------

                    Acconting.DataLayer.Goods g = new Acconting.DataLayer.Goods();
                    var result = goods.GetGoodsById(Convert.ToInt32(dgvList.Rows[dgvList.Rows.Count - 2].Cells["Column1"].Value));


                    g.ID = Convert.ToInt32(id);
                    g.Name = result.Name.ToString();
                    g.PurchasePrice = result.PurchasePrice.ToString();
                    g.SalesPrice = result.SalesPrice.ToString();
                    g.Numbers = Convert.ToInt32(result.Numbers - Convert.ToInt32(dgvList.Rows[dgvList.Rows.Count - 2].Cells["clmNumber"].Value));
                    g.InsertDate = DateTime.Now;
                    g.company = result.company.ToString();

                    //---------------------------------------------
                    dgvList.Rows.RemoveAt(dgvList.Rows.Count - 2);

                    goods.UpdateGoods(g);
                    goods.Save();

                    buy.Save();

                }
            }
            //---------------------------------------------
            string nameFamily;
            Acconting.DataLayer.Invoice p1 = new Acconting.DataLayer.Invoice();
            p1.InvoiceNumber = invoiceNumber;
            p1.Price = Convert.ToDouble(lblFinalyPrice.Text).ToString("#,#");
            //---------------------------------------------

            Forms.Invoice.AddInvoice.frmAddInvoice frm = new Forms.Invoice.AddInvoice.frmAddInvoice();
            frm.ShowDialog();
            nameFamily = p1.NameFamily = frm.name1;
            frm.Dispose();
            p1.Data = new DateAndTime().PersianDate() + "-" + new DateAndTime().time();
            invoice.InsertInvoice(p1);
            invoice.Save();
            //---------------------------------------------

            if (MessageBox.Show("ایا فاکتور چاپ شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Forms.Invoice.InvoiceList.frmInvoiceList frm1 = new Forms.Invoice.InvoiceList.frmInvoiceList();
                frm1.InvoiceNumber = invoiceNumber;
                frm1.CustomerName = nameFamily.ToString();
                frm1.Show();
                frm1.picPrint_Click(null, null);
            }
            //---------------------------------------------
            dgvList.Rows.Clear();
            lblFinalyPrice.Text = "0";
            lblDiscount.Text = "0";
            txtDiscount.Value = 0;
            group2.Enabled = false;
            //---------------------------------------------

            refreshDate();


        }

        private void DgvList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }

        private void TxtDiscount_ValueChanged(object sender, EventArgs e)
        {
            lblDiscount.Text = ((Convert.ToDouble(lblFinalyPrice.Text.Replace(",", string.Empty)) / 100) * (100 - Convert.ToDouble(txtDiscount.Value))).ToString("#,#");
        }

        private void cmsDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows != null)
            {
                if (MessageBox.Show("آیا از حذف '" + dgvList.SelectedRows[0].Cells[0].Value + "' از سبد خرید مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvList.Rows.RemoveAt(dgvList.SelectedRows[0].Index);
                }

            }
        }

        private void cmsAddToInvoice_Click(object sender, EventArgs e)
        {
            BtnSubmit_Click(null, null);
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            if (txtSearch.Text != null || txtSearch.Text != string.Empty)
            {
                dgvGoostList.DataSource = goods.GetAllGoods().Where(p => p.Name.Contains(txtSearch.Text) && p.Numbers > 0).ToList();
            }
            else
            {
                refreshDate();
            }
        }

        private void txtNumbers_ValueChanged_1(object sender, EventArgs e)
        {

            txtNumbers.Maximum = Convert.ToInt32(dgvGoostList.SelectedCells[4].Value);
        }
    }
}
