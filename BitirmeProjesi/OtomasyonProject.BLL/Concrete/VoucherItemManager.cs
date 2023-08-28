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
    public class VoucherItemManager : IVoucherItemService
    {
        private readonly IVoucherItemDAL _voucherItemDAL;

        public VoucherItemManager(IVoucherItemDAL voucherItemDAL)
        {
            _voucherItemDAL = voucherItemDAL;
        }

        public void TDelete(VoucherItem t)
        {
            _voucherItemDAL.Delete(t);
        }

        public VoucherItem TGetById(int id)
        {
            return _voucherItemDAL.GetById(id);
        }

        public List<VoucherItem> TGetList()
        {
            return _voucherItemDAL.GetList();
        }

        public void TInsert(VoucherItem t)
        {
            _voucherItemDAL.Insert(t);
        }

        public void TUpdate(VoucherItem t)
        {
            _voucherItemDAL.Update(t);
        }
    }
}
