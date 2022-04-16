using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting.utility
{
    public class CFormAndOForm
    {
        private Form newForm { get; set; }

        public void switchForm(Form closedForm, Form openForm)
        {
            newForm = openForm;
            closeThisForm(closedForm);

        }


        private void closeThisForm(Form form)
        {

            new Animation().animationClose(5, form);

            Thread mythread = new Thread(new ThreadStart(OpenNewFrom));
            mythread.Start();
            form.Close();
        }

        private void OpenNewFrom()
        {
            Application.Run(newForm);
        }
    }
}
