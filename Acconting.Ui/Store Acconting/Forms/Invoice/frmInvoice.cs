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

namespace Store_Acconting.Forms.Invoice
{
    public partial class frmInvoice : Form
    {
        IInvoiceRepository invoice = new InvoiceRepository();

        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvInvoice.BackgroundColor = Properties.Settings.Default.BackColor;
            dgvInvoice.DataSource = invoice.GetAllInvoices().ToList();
        }

        private void picClose_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void cmsEditInvoice_Click(object sender, EventArgs e)
        {
            btnEditInvoice_Click(null, null);
        }

        private void cmsDeleteInvoice_Click(object sender, EventArgs e)
        {
            btnDeleteInvoice_Click(null, null);
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
           // Invoice invoice = new Invoice();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "آیا از حذف فاکتور شماره '" + dgvInvoice.SelectedCells[4].Value + "' اطمینان دارید؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //---------------------------------------------
                invoice.DeleteInvoice(Convert.ToInt32(dgvInvoice.SelectedCells[0].Value));
                invoice.Save();
                frmInvoice_Load(null, null);
                //---------------------------------------------
            }

        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //---------------------------------------------
            Forms.Invoice.InvoiceList.frmInvoiceList frm = new InvoiceList.frmInvoiceList();
            frm.InvoiceNumber = Convert.ToInt32(dgvInvoice.SelectedCells[4].Value);
            frm.CustomerName = dgvInvoice.SelectedCells[1].Value.ToString();
            frm.ShowDialog();
            //---------------------------------------------
        }
    }
}
