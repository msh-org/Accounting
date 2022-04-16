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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Acconting.Forms.Settings
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        IAdminRepository admin = new AdminRepository();



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void group2_Enter_1(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtCaptcha.Text = new Random().Next(10000, 99999).ToString();
            foreach (var item in admin.GetAllAdmins())
            {
                cmbEditUser.Items.Add(item.Name);
            }

            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
            this.BackColor = tabControl1.TabPages[0].BackColor = tabControl1.TabPages[1].BackColor = tabControl1.TabPages[2].BackColor = Properties.Settings.Default.BackColor;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IAdminRepository Admin = new AdminRepository();
            if (Admin.isValidAdmin(txtUsernameReset.Text, txtPasswordReset.Text))
            {
                if (txtConfirmCaptcha.Text == txtCaptcha.Text)
                {


                    if (MessageBox.Show("آیا از حذف تمامی داده های برنامه از قبیل 'کالا ها ، فاکتور ها،خرید و فروش ها' اطمینان دارید؟\r\n بعد از حذف امکان بازیابی وجود ندارد.", "هشدار!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        IGoodsRepository goods = new GoodsRepository();
                        foreach (var item in goods.GetAllGoods())
                        {
                            goods.DeleteGoods(item);
                        }
                        goods.Save();

                        IInvoiceRepository invoice = new InvoiceRepository();
                        foreach (var item in invoice.GetAllInvoices())
                        {
                            invoice.DeleteInvoice(item);
                        }
                        invoice.Save();

                        IBuyRepository buy = new BuyRepository();
                        foreach (var item in buy.GetAllBuys())
                        {
                            buy.DeleteBuy(item);
                        }
                        buy.Save();
                        MessageBox.Show("کلیه دیتا های برنامه پاک شد.");
                    }
                }
                else
                {
                    txtCaptcha.Text = new Random().Next(10000, 99999).ToString();
                    MessageBox.Show("کد امنیتی اشتباه است.");
                }
            }
            else
            {
                txtCaptcha.Text = new Random().Next(10000, 99999).ToString();
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            }

        }

        private void rbnAdd_CheckedChanged(object sender, EventArgs e)
        {
            group1.Enabled = false;
            group2.Enabled = true;
        }

        private void rbnEdit_CheckedChanged(object sender, EventArgs e)
        {
            group1.Enabled = true;
            group2.Enabled = false;
        }

        private void picUpdateCaptcha_Click(object sender, EventArgs e)
        {
            txtCaptcha.Text = new Random().Next(10000, 99999).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbnAdd.Checked == true)
            {
                Admin a = new Admin();
                a.Name = txtNewName.Text;
                a.Password = txtNewPassword.Text;
                a.LastLogin = new DateAndTime().PersianDate() + "-" + new DateAndTime().time();
                if (chkNewMainAdmin.Checked == true)
                {
                    a.Post = 1;
                }
                else
                {
                    a.Post = 1;
                }
                admin.InsertAdmin(a);
                admin.Save();
            }
            else if (rbnEdit.Checked == true)
            {
                int id = 0;
                Admin admin1 = new Admin();
                admin1.Name = txtEditNewUsername.Text;
                admin1.Password = txtEditNewPassword.Text;
                if (chkEditNewMainAdmin.Checked == true)
                {
                    admin1.Post = 1;
                }
                else
                {
                    admin1.Post = 0;
                }
                foreach (var item in admin.GetAllAdmins())
                {
                    if (item.Name == cmbEditUser.Text)
                    {
                        id = item.ID;
                    }
                }
                admin1.ID = id;
                admin1.LastLogin = new DateAndTime().PersianDate() + "-" + new DateAndTime().time();
                admin.UpdateAdmin(admin1);
                admin.Save();
                this.Close();
            }
        }

        private void group2_Enter(object sender, EventArgs e)
        {
            group2.Enabled = true;
            group1.Enabled = false;
        }

        private void EditHeaderColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.HeaderColor = colorDialog.Color;
                PreviewHeaderPanel1.GradientBottomLeft = PreviewHeaderPanel1.GradientTopLeft = PreviewHeaderPanel1.GradientTopRight = Properties.Settings.Default.HeaderColor;
            }
        }

        private void EditMainColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackColor = colorDialog.Color;
                MainPannel1.BackColor = Properties.Settings.Default.BackColor;
            }
        }

        private void ResetThemeButten_Click(object sender, EventArgs e)
        {

        }

        private void ExitAndSave_Click(object sender, EventArgs e)
        {

        }

        private void tabTheme_Click(object sender, EventArgs e)
        {


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا تغییرات اعمال شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                Application.Restart();
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemeDefultButton_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.HeaderColor = PreviewHeaderPanelDefult.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannelDefult.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }
        void AcceptMessage()
        {
            if (MessageBox.Show("پوسه با موفقیت نصب شد. برای اکنون باید برنامه مجدد اجرا شود در غیر این صورت تا وقتی برنامه بسته و دوباره باز نشود پوسته به درستی کار نمیکنید. آیا اکنون برنامه مجدد اجرا شود؟"
                , "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void Theme1Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel1.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel1.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }

        private void Theme2Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel2.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel2.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }

        private void Theme3Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel3.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel3.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }

        private void Theme4Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel4.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel4.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }

        private void Theme5Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel5.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel5.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }

        private void Theme6Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HeaderColor = PreviewHeaderPanel6.GradientTopRight;
            Properties.Settings.Default.BackColor = MainPannel6.BackColor;
            Properties.Settings.Default.Save();
            AcceptMessage();
        }
    }
}
