using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfCurrentCartDal : GenericRepository<CurrentCard>, ICurrentDAL
    {
        public EfCurrentCartDal(Context context) : base(context)
        {
        }
    }
}
