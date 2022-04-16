using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.DataLayer.Repositories
{
    public interface IGoodsRepository
    {     
        
        List<Goods> GetAllGoods();
        Goods GetGoodsById(int goodsId);
        bool InsertGoods(Goods goods);
        bool UpdateGoods(Goods goods);
        bool DeleteGoods(Goods goods);
        bool DeleteGoods(int goodsId);       
        List<Goods> Search(string text);
        void Save();
    }
}
