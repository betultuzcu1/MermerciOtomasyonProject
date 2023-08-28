using HotelProject.DAL.Absctract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using OtomasyonProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DAL.EntityFramework
{
    public class EfMarbleBlockDal : GenericRepository<MarbleBlock>, IMarbleBlockDAL
    {
        public EfMarbleBlockDal(Context context) : base(context)
        {
        }
    }
}
