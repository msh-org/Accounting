using Acconting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Services
{
    public class BuyRepository : IBuyRepository
    {
        Acconting_DBEntities db = new Acconting_DBEntities();

        public int CountBuy()
        {
            return db.Buys.Count();
        }

        public bool DeleteBuy(Buys buy)
        {
            try
            {
                db.Entry(buy).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBuy(int buyId)
        {
            try
            {
                var result = GetBuyById(buyId);
                DeleteBuy(result);
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

        public List<Buys> GetAllBuys()
        {
            return db.Buys.ToList();
           
        }

        public Buys GetBuyById(int buyId)
        {
            return db.Buys.Find(buyId);
        }
        public List<Buys> GetBuysByInvoiceNumber(int InvoiceNumber)
        {
            return db.Buys.Where(p => p.InvoiceNumber == InvoiceNumber).ToList();
        }

        public int getLastInvoiceNumber()
        {
            try
            {
                return db.Buys.Max(p => p.InvoiceNumber);
            }
            catch
            {
                return 1;
            }
        }

        public bool InsertBuy(Buys buy)
        {
            try
            {
                db.Buys.Add(buy);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdateBuy(Buys buy)
        {
            try
            {
                var local = db.Set<Goods>()
                         .Local
                         .FirstOrDefault(f => f.ID == buy.ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }

                using (Acconting_DBEntities d = new Acconting_DBEntities())
                {
                    db.Entry(buy).State = System.Data.Entity.EntityState.Modified;
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
