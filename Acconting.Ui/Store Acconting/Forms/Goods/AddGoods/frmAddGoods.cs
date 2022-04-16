using Acconting.DataLayer.Repositories;
using Acconting.DataLayer.Services;
using System;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Goods.AddGoods
{

    public partial class frmAddGoods : Form
    {

        //---------------------------------------------
        public int user { get; set; }
        //---------------------------------------------


        //---------------------------------------------
        IGoodsRepository goods = new GoodsRepository();
        //---------------------------------------------
        
        public frmAddGoods()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            Acconting.DataLayer.Goods p = new Acconting.DataLayer.Goods();

            //---------------------------------------------
            p.ID = user;
            p.Name = txtName.Text;
            p.PurchasePrice = txtPurchasePrice.Text;
            p.SalesPrice = txtSalesPrice.Text;
            p.Numbers = (int)txtNumbers.Value;
            p.InsertDate = DateTime.Now;
            p.company = txtCompany.Text;
            //---------------------------------------------


            if (user != 0)
            {
                p.ID = user;
                goods.UpdateGoods(p);
            }
            else
            {
                goods.InsertGoods(p);
            }

            goods.Save();
            DialogResult = DialogResult.OK;
        }

        private void FrmAddGoods_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = Properties.Settings.Default.BackColor;

            if (user != 0)
            {
                //---------------------------------------------
                btnSubmit.ButtonText = "ویرایش";
                lblTitle.Text = "ویرایش کالا";
                var result = goods.GetGoodsById(user);
                txtName.Text = result.Name;
                txtPurchasePrice.Text = result.PurchasePrice;
                txtSalesPrice.Text = result.SalesPrice;
                txtNumbers.Value = result.Numbers;
                txtCompany.Text = result.company;
                //---------------------------------------------
            }
        }

        private void txtPurchasePrice_TextChange(object sender, EventArgs e)
        {
            try
            {

                if (((TextBox)sender).Text != string.Empty)
                {
                    ((TextBox)sender).Text = Int64.Parse(((TextBox)sender).Text.Replace(",", "")).ToString("#,0");
                    ((TextBox)sender).Select(((TextBox)sender).TextLength, 0);
                }
            }
            catch
            {
                
            }
        }
    }
}
