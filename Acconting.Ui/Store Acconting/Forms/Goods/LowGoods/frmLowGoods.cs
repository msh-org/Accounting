using Acconting.DataLayer;
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

namespace Store_Acconting.Forms.Goods.LowGoods
{
    public partial class frmLowGoods : Form
    {
        public frmLowGoods()
        {
            InitializeComponent();
        }

        IGoodsRepository Goods = new GoodsRepository();
        private void frmLowGoods_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = dgvEndGoostList.BackgroundColor = dgvLowGoostList.BackgroundColor = Properties.Settings.Default.BackColor;

            dgvLowGoostList.DataSource = Goods.GetAllGoods().Where(p => p.Numbers <= 10 && p.Numbers > 0).ToList();
            dgvEndGoostList.DataSource = Goods.GetAllGoods().Where(p => p.Numbers < 1).ToList();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
