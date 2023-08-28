using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;


namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfPlateDal : GenericRepository<Plate>, IPlateDAL
    {
        public EfPlateDal(Context context) : base(context)
        {
        }
    }
}
