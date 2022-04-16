using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Repositories
{
    public interface IAdminRepository
    {

        List<Admin> GetAllAdmins();
        Admin GetAdminById(int adminId);
        bool InsertAdmin(Admin admin);
        bool UpdateAdmin(Admin admin);
        bool DeleteAdmin(Admin admin);
        bool DeleteAdmin(int AdminId);
        bool isValidAdmin(string Username, string Password);
        void Save();
    }
}
