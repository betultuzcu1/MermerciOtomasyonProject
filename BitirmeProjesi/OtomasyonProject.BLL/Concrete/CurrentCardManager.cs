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
    public class CurrentCardManager : ICurrentCardService
    {
        private readonly ICurrentDAL _currentDAL;

        public CurrentCardManager(ICurrentDAL currentDAL)
        {
            _currentDAL = currentDAL;
        }

        public void TDelete(CurrentCard t)
        {
            _currentDAL.Delete(t);
        }

        public CurrentCard TGetById(int id)
        {
            return _currentDAL.GetById(id);
        }

        public List<CurrentCard> TGetList()
        {
            return _currentDAL.GetList();
        }

        public void TInsert(CurrentCard t)
        {
            _currentDAL.Insert(t);
        }

        public void TUpdate(CurrentCard t)
        {
            _currentDAL.Update(t);
        }
    }
}
