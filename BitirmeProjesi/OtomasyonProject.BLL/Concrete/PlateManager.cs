using HotelProject.DAL.Absctract;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.BLL.Concrete
{
    public class PlateManager : IPlateService
    {
        private readonly IPlateDAL _plateDAL;

        public PlateManager(IPlateDAL plateDAL)
        {
            _plateDAL = plateDAL;
        }

        public void TDelete(Plate t)
        {
            _plateDAL.Delete(t);
        }

        public Plate TGetById(int id)
        {
            return _plateDAL.GetById(id);
        }

        public List<Plate> TGetList()
        {
            return _plateDAL.GetList();
        }

        public void TInsert(Plate t)
        {
            _plateDAL.Insert(t);
        }

        public void TUpdate(Plate t)
        {
            _plateDAL.Update(t);
        }
    }
}
