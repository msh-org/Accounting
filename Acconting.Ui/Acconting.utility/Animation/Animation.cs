using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting.utility
{
    public class Animation
    {
        //animation Form
        #region animation
        public void animationClose(int Op, Form form)
        {
            form.Opacity = 1;
            while (form.Opacity > 0)
            {
                form.Opacity -= 0.01;
                Thread.Sleep(Op);
            }
        }
        public void animationOpen(int Op, Form form)
        {
            form.Opacity = 0;
            while (form.Opacity < 1)
            {
                form.Opacity += 0.01;
                Thread.Sleep(Op);
            }
        }
        #endregion
    }
}
