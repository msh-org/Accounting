using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Repositories
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int invoiceId);

        bool InsertInvoice(Invoice invoice);
        bool UpdateInvoice(Invoice invoice);
        bool DeleteInvoice(Invoice invoice);
        bool DeleteInvoice(int invoiceId);
        int GetLastId();

        void Save();
    }
}
