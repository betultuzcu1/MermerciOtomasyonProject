using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfVoucherDal : GenericRepository<Voucher>, IVoucherDAL
    {
        public EfVoucherDal(Context context) : base(context)
        {
        }
    }
}
