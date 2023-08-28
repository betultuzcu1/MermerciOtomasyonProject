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
    public class VoucherManager : IVoucherService
    {
        private readonly IVoucherDAL _voucherDAL;

        public VoucherManager(IVoucherDAL voucherDAL)
        {
            _voucherDAL = voucherDAL;
        }

        public void TDelete(Voucher t)
        {
            _voucherDAL.Delete(t);
        }

        public Voucher TGetById(int id)
        {
            return _voucherDAL.GetById(id);
        }

        public List<Voucher> TGetList()
        {
            return _voucherDAL.GetList();
        }

        public void TInsert(Voucher t)
        {
            _voucherDAL.Insert(t);
        }

        public void TUpdate(Voucher t)
        {
            _voucherDAL.Update(t);
        }
    }
}
