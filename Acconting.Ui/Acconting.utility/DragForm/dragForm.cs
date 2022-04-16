using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting.utility
{
    public class dragForm
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void MouseDown(Form form)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = form.Location;
        }

        public void MouseMove(Form form)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                form.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        public void MouseUp(Form form)
        {
            dragging = false;
        }
    }
}
