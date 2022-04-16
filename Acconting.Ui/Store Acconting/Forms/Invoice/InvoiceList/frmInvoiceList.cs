using Acconting.DataLayer.Repositories;
using Acconting.DataLayer.Services;
using Acconting.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Invoice.InvoiceList
{
    public partial class frmInvoiceList : Form
    {
        //---------------------------------------------
        IBuyRepository buys = new BuyRepository();
        //---------------------------------------------

        //---------------------------------------------
        public int InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        //---------------------------------------------
        
        public frmInvoiceList()
        {
            InitializeComponent();

        }

        private void frmInvoiceList_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvList.BackgroundColor = Properties.Settings.Default.BackColor;

            dgvList.DataSource = buys.GetBuysByInvoiceNumber(InvoiceNumber);
            lblTitle.Text = "فاکتور شماره #" + InvoiceNumber;
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

                lblFinalyPrice.Text ="قیمت کل: " + p.ToString("#,#") + "ريال";
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void picPrint_Click(object sender, EventArgs e)
        {
            int p = 0;
            DataTable dtPrint = new DataTable();
            //---------------------------------------------
            dtPrint.Columns.Add("invoiceNumber");
            dtPrint.Columns.Add("Name");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Price");
            dtPrint.Columns.Add("Discont");
            dtPrint.Columns.Add("DiscontPrice");
            dtPrint.Columns.Add("Condition");
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("PrintTime");
            dtPrint.Columns.Add("FinalyPrice");
            //---------------------------------------------

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
                p += Convert.ToInt32(str.Replace(",",string.Empty));
                //---------------------------------------------
                dtPrint.Rows.Add(
                    item.Cells[7].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[6].Value.ToString(),
                    CustomerName.ToString(),
                    new DateAndTime().PersianDate() + "-" + new DateAndTime().time(),
                    "ريال"+" "+p.ToString("#,#") 
                    ) ;
                lblFinalyPrice.Text = p + " ریال";
                //---------------------------------------------
            }

            stiPrint.Load(Application.StartupPath + @"\printing\InvoiceReport.mrt");
            stiPrint.RegData("DtInvoice", dtPrint);
            stiPrint.Show();
        }
        
    }
}
