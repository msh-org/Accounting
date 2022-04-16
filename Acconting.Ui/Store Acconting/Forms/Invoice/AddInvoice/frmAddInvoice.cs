using Acconting.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Invoice.AddInvoice
{
    public partial class frmAddInvoice : Form
    {
        public frmAddInvoice()
        {
            InitializeComponent();
        }
        public string name1 { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text != null || txtName.Text != string.Empty)
            {
                name1 = txtName.Text;
                
            }
            else
            {
                name1 = "نامی وارد نشده است";
            }
            this.Hide();
        }
    }
}
