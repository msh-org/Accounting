using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Repositories
{
    public interface IBuyRepository
    {
        List<Buys> GetAllBuys();
        List<Buys> GetBuysByInvoiceNumber(int InvoiceNumber);
        Buys GetBuyById(int buyId);
        bool InsertBuy(Buys buy);
        bool UpdateBuy(Buys buy);
        bool DeleteBuy(Buys buy);
        bool DeleteBuy(int buyId);
        int getLastInvoiceNumber();
        int CountBuy();
        void Dispose();
        void Save();
    }
}
