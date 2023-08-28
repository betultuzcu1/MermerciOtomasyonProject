using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.Concrete;
using OtomasyonProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;


namespace OtomasyonProject.DAL.EntityFramework
{
    public class EfMarbleBlockDal : GenericRepository<MarbleBlock>, IMarbleBlockDAL
    {
        public EfMarbleBlockDal(Context context) : base(context)
        {
        }
    }
}
