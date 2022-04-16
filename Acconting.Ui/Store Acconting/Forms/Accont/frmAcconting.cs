using Acconting.DataLayer.Repositories;
using Acconting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Accont
{
    public partial class frmAcconting : Form
    {
        public frmAcconting()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        IBuyRepository buys = new BuyRepository();
        private void frmAcconting_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvList.BackgroundColor = Properties.Settings.Default.BackColor;

            dgvList.DataSource = buys.GetAllBuys().OrderBy(p => p.InvoiceNumber).ToList();

            updatePrice();

        }

        void updatePrice()
        {

            int p = 0;
            foreach (DataGridViewRow item in dgvList.Rows)
            {
                string str;
                if (item.Cells[4].Value.ToString() == "" || item.Cells[4].Value.ToString() == null)
                {
                    str = item.Cells[2].Value.ToString();
                }
                else
                {
                    str = item.Cells[4].Value.ToString();

                }
                p += Convert.ToInt32(str.Replace(",", string.Empty));

                lblFinalyPrice.Text = "قیمت کل: " + p.ToString("#,#") + "ريال";
            }
        }

        private void txtSearch_TextChange_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == null || txtSearch.Text == string.Empty)
                {
                    frmAcconting_Load(null, null);
                }
                else
                {
                    if (radSearchByInvoiceNumber.Checked == true)
                    {
                        dgvList.DataSource = buys.GetAllBuys().Where(p => p.InvoiceNumber == Convert.ToInt32(txtSearch.Text)).ToList();
                    }
                    else if (radSearchByName.Checked == true)
                    {
                        dgvList.DataSource = buys.GetAllBuys().Where(p => p.Name.Contains(txtSearch.Text.ToString())).ToList();
                    }
                }
            }
            catch
            {

            }
            updatePrice();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = buys.GetAllBuys().Where(p =>
                Convert.ToDouble(p.Price.Replace(",", string.Empty)) >=
                Convert.ToInt32(txtFirtPrice.Text.Replace(",","")) && Convert.ToDouble(p.Price.Replace(",", string.Empty))
                <= Convert.ToInt32(txtLastPrice.Text.Replace(",", ""))).OrderBy(p => p.Price).ToList();
                updatePrice();
            }
            catch 
            {
                MessageBox.Show("مشکلی پیش آمده است ");
            }
        }

        private void picPrint_Click(object sender, EventArgs e)
        {

            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("invoiceNumber");
            dtPrint.Columns.Add("Name");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Price");
            dtPrint.Columns.Add("Discont");
            dtPrint.Columns.Add("DiscontPrice");
            dtPrint.Columns.Add("Condition");

            foreach (DataGridViewRow item in dgvList.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[7].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[6].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + @"\printing\Report.mrt");
            stiPrint.RegData("DtPrint", dtPrint);
            stiPrint.Show();
        }

        private void radOrderByName_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = buys.GetAllBuys().OrderBy(p => p.Name).ToList();
        }

        private void radOrderByDate_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = buys.GetAllBuys().OrderBy(p => p.Date).ToList();
        }

        private void radOrderByInvoiceNumber_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = buys.GetAllBuys().OrderBy(p => p.InvoiceNumber).ToList();
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtFirtPrice_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != string.Empty)
            {
                ((TextBox)sender).Text = Int64.Parse(((TextBox)sender).Text.Replace(",", "")).ToString("#,0");
                ((TextBox)sender).Select(((TextBox)sender).TextLength, 0);
            }
        }

        private void picPrint_MouseMove(object sender, MouseEventArgs e)
        {
            picPrint.Size = new Size(49, 49);
        }

        private void picPrint_MouseLeave(object sender, EventArgs e)
        {
            picPrint.Size = new Size(48, 48);
        }
    }
}
