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

namespace Store_Acconting.Forms.Login
{
    public partial class frmLogin : Form
    {
        IAdminRepository Admin = new AdminRepository();
        public frmLogin()
        {
            InitializeComponent();
 
        }          

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (Admin.isValidAdmin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show( txtUsername.Text + " جان خوش آمدید");
                new Animation().animationClose(5, this);
                Thread mythread = new Thread(new ThreadStart(OpenNewFrom));
                mythread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("شما ادمین نیستید");
            }
        }
        private static void OpenNewFrom()
        {
            Application.Run(new Forms.Main.frmMain());
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlHeader.GradientBottomLeft = pnlHeader.GradientTopLeft = pnlHeader.GradientTopRight = Properties.Settings.Default.HeaderColor;
        }
    }
}
