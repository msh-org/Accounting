using Acconting.DataLayer;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            new CenterControl().Center(lblTitle, this);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            new Animation().animationClose(5, this);
            Thread mythread = new Thread(new ThreadStart(OpenNewFrom));
            mythread.Start();
            this.Dispose();
        }

        dragForm dragForm = new dragForm();
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.MouseDown(this);
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm.MouseMove(this);
        }

        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm.MouseUp(this);
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = new DateAndTime().time().currentPersian();
            lblDate.Text = new DateAndTime().PersianDate().currentPersian();

        }

        private void PicContactUs_Click(object sender, EventArgs e)
        {
            new Forms.ContactUs.ContactUs().ShowDialog();
            
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            new Forms.Buy.frmBuy().Show();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicClose_MouseMove(object sender, MouseEventArgs e)
        {

            ((PictureBox)sender).Size = new Size(36, 36);
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(35, 35);
        }

        private void PicHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private static void OpenNewFrom()
        {
            Application.Run(new Forms.Login.frmLogin());
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            new Forms.Goods.GoodsList.frmGoodsList().Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            new Forms.Invoice.frmInvoice().Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Forms.Settings.frmSettings().ShowDialog();
        }

        private void btnAcconting_Click(object sender, EventArgs e)
        {
            new Forms.Accont.frmAcconting().ShowDialog();
        }

        IBuyRepository buy = new BuyRepository();

        private void tmr_Tick(object sender, EventArgs e)
        {
            refreshChart();
        }
        void refreshChart()
        {
            chart1.Series[0].Points.Clear();
            foreach (var item in buy.GetAllBuys())
            {
                chart1.Series[0].Points.AddY(item.DiscountPrice);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refreshChart();
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = picContactUs.BackColor = chart1.BackColor  = pnlFooter.GradientBottomLeft = pnlFooter.GradientBottomRight = pnlFooter.GradientTopLeft = pnlFooter.GradientTopRight = Properties.Settings.Default.BackColor;
        }
    }
}
