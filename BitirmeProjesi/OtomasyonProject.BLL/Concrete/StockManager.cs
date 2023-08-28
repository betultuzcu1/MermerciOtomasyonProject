using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.BLL.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IStockDAL _stockDAL;

        public StockManager(IStockDAL stockDAL)
        {
            _stockDAL = stockDAL;
        }

        public void TDelete(Stock t)
        {
            _stockDAL.Delete(t);
        }

        public Stock TGetById(int id)
        {
            return _stockDAL.GetById(id);
        }

        public List<Stock> TGetList()
        {
            return _stockDAL.GetList();
        }

        public void TInsert(Stock t)
        {
            _stockDAL.Insert(t);
        }

        public void TUpdate(Stock t)
        {
            _stockDAL.Update(t);
        }
    }
}
