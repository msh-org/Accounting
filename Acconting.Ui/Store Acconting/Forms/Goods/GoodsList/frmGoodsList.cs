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

namespace Store_Acconting.Forms.Goods.GoodsList
{
    public partial class frmGoodsList : Form
    {
        //---------------------------------------------
        IGoodsRepository Goods = new GoodsRepository();
        //---------------------------------------------

        public frmGoodsList()
        {
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PicClose_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Size = new Size(36, 36);
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(35, 35);
        }

        private void FrmGoodsList_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvGoostList.BackgroundColor = Properties.Settings.Default.BackColor;
            reloadDate();

        }

        private void reloadDate()
        {

            dgvGoostList.DataSource = Goods.GetAllGoods();
        }

        private void BtnAddGoods_Click(object sender, EventArgs e)
        {
            new Forms.Goods.AddGoods.frmAddGoods().ShowDialog();
            reloadDate();
        }

        private void BtnDeleteGoods_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("آیا از حذف '" + dgvGoostList.SelectedCells[1].Value.ToString()
                + "' مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Goods.DeleteGoods(int.Parse(dgvGoostList.SelectedCells[0].Value.ToString()));
                Goods.Save();
                reloadDate();
            }

        }

        private void TxtSearchGoods_TextChange(object sender, EventArgs e)
        {
            dgvGoostList.DataSource = Goods.Search(txtSearchGoods.Text);
        }

        private void BtnEditGoods_Click(object sender, EventArgs e)
        {
            
                Forms.Goods.AddGoods.frmAddGoods frm = new AddGoods.frmAddGoods();
                frm.user = (int)dgvGoostList.SelectedCells[0].Value;
                if (frm.ShowDialog() == DialogResult.OK) { reloadDate(); }

           
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (dgvGoostList.SelectedRows != null)
            {
                BtnEditGoods_Click(null, null);
            }
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (dgvGoostList.SelectedRows != null)
            {
                BtnDeleteGoods_Click(null, null);
            }
        }

        private void btnLowGoods_Click(object sender, EventArgs e)
        {
            new Forms.Goods.LowGoods.frmLowGoods().ShowDialog();
        }
    }
}

