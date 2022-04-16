using Acconting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Services
{
    public class InvoiceRepository : IInvoiceRepository
    {
        Acconting_DBEntities db = new Acconting_DBEntities();
        public bool DeleteInvoice(Invoice invoice)
        {
            try
            {
                db.Entry(invoice).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteInvoice(int invoiceId)
        {
            try
            {
                var result = GetInvoiceById(invoiceId);
                DeleteInvoice(result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Invoice> GetAllInvoices()
        {
            return db.Invoice.ToList();
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return db.Invoice.Find(invoiceId);
        }


        public int GetLastId()
        {
            return db.Invoice.Max(p => p.ID);
        }

        public bool InsertInvoice(Invoice invoice)
        {
            try
            {

                db.Invoice.Add(invoice);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            //        List<string> ts = new List<string>(); 
            //try
            //{
                db.SaveChanges();

            //}catch(DbEntityValidationException e)
            //{
                
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        ts.Add(("Entity of type \"" + eve.Entry.Entity.GetType().Name + " in state \"" + eve.Entry.State + " has the following validation errors:".ToString())); ;
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            ts.Add("- Property: \"" + ve.PropertyName + ", Error: \"" + ve.ErrorMessage ) ;
            //        }
            //    }
        //    }
        }

        public bool UpdateInvoice(Invoice invoice)
        {
            try
            {
                var local = db.Set<Goods>()
                         .Local
                         .FirstOrDefault(f => f.ID == invoice.ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }

                using (Acconting_DBEntities d = new Acconting_DBEntities())
                {
                    db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                    return true;

                }
            }
            catch
            {
                return false;
            }
        }
    }
}
