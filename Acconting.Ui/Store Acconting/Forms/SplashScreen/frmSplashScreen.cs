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

namespace Store_Acconting.Forms.SplashScreen
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            new Animation().animationOpen(5, this);
            new CenterControl().Center(lblAppName, this);
            new CenterControl().Center(lblPleaseWait, this);
        }
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void FrmSplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TmrClose_Tick(object sender, EventArgs e)
        {
            lineLoadBar.Width = lineLoadBar.Width + 3;
            lblLoadBar.Text = "در حال بارگذاری " + Convert.ToString(lineLoadBar.Width / 3).currentPersian() + "%";
            new CenterControl().Center(lblLoadBar, this);
            if (lineLoadBar.Width / 3 >= 100)
            {
                new Animation().animationClose(5, this);

                Thread mythread = new Thread(new ThreadStart(OpenNewFrom));
                mythread.Start();
                this.Close();

                tmrClose.Enabled = false;
                tmrClose.Dispose();
            }
        }
        private static void OpenNewFrom()
        {
            Application.Run(new Forms.Login.frmLogin());
        }
    }
}
