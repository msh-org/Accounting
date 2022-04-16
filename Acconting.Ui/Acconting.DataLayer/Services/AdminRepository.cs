using Acconting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Services
{
    public class AdminRepository : IAdminRepository
    {
        Acconting_DBEntities db = new Acconting_DBEntities();
        public bool DeleteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAdmin(int AdminId)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdminById(int adminId)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAllAdmins()
        {
            return db.Admin.ToList();
        }

        public bool InsertAdmin(Admin admin)
        {
            try
            {
                db.Admin.Add(admin);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isValidAdmin(string Username, string Password)
        {
                bool isValid = false;
            try
            {
                var p = db.Admin.Where(a => a.Name == Username && a.Password == Password).FirstOrDefault();
                if (p != null)
                {
                    isValid = true;
                }
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdateAdmin(Admin admin)
        {

            try
            {
                var local = db.Set<Admin>()
                        .Local
                        .FirstOrDefault(f => f.ID == admin.ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }

                using (Acconting_DBEntities d = new Acconting_DBEntities())
                {
                    db.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                    return true;

                }
                //return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
