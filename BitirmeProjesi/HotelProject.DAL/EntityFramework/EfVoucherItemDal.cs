
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;


namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfVoucherItemDal : GenericRepository<VoucherItem>, IVoucherItemDAL
    {
        public EfVoucherItemDal(Context context) : base(context)
        {
        }
    }
}
