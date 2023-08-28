using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;


namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfStockDal : GenericRepository<Stock>, IStockDAL
    {
        public EfStockDal(Context context) : base(context)
        {
        }
    }
}
