using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting.utility
{
    public class CenterControl
    {
        public void Center(Control control, Form form)
        {
            int formWidth = form.Width;
            int controlWidth = control.Width;
            control.Location = new Point((formWidth / 2) - (controlWidth / 2), control.Location.Y);
        }
    }
}
