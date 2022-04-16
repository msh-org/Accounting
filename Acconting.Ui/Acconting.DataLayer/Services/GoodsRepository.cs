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
    public class GoodsRepository : IGoodsRepository 
    {
        Acconting_DBEntities db = new Acconting_DBEntities();

        public bool DeleteGoods(Goods goods)
        {
            try
            {
                db.Entry(goods).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGoods(int goodsId)
        {
            try
            {
                var result = GetGoodsById(goodsId);
                DeleteGoods(result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispise()
        {
            db.Dispose();
        }



        public List<Goods> GetAllGoods()
        {
            return db.Goods.ToList();
        }

        public Goods GetGoodsById(int goodsId)
        {
            return db.Goods.Find(goodsId);
        }

        public bool InsertGoods(Goods goods)
        {
            try
            {
                db.Goods.Add(goods);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            List<string> ts = new List<string>();
            try
            {
                db.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {

                foreach (var eve in e.EntityValidationErrors)
                {
                    ts.Add(("Entity of type \"" + eve.Entry.Entity.GetType().Name + " in state \"" + eve.Entry.State + " has the following validation errors:".ToString())); ;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        ts.Add("- Property: \"" + ve.PropertyName + ", Error: \"" + ve.ErrorMessage);
                    }
                }
            }
        }

        public List<Goods> Search(string text)
        {
            return db.Goods.Where(p => p.Name.Contains(text) || p.company.Contains(text)).ToList();
        }

        public bool UpdateGoods(Goods goods)
        {
            try
            {
                var local = db.Set<Goods>()
                         .Local
                         .FirstOrDefault(f => f.ID == goods.ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }

                using (Acconting_DBEntities d = new Acconting_DBEntities())
                {
                    db.Entry(goods).State = System.Data.Entity.EntityState.Modified;
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
