using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProject.BLL.Concrete
{
    public class MarbleBlockManager : IMarbleBlockService
    {
        private readonly IMarbleBlockDAL _marbleBlockDAL;

        public MarbleBlockManager(IMarbleBlockDAL marbleBlockDAL)
        {
            _marbleBlockDAL = marbleBlockDAL;
        }

        public void TDelete(MarbleBlock t)
        {
            _marbleBlockDAL.Delete(t);
        }

        public MarbleBlock TGetById(int id)
        {
            return _marbleBlockDAL.GetById(id);
        }

        public List<MarbleBlock> TGetList()
        {
            return _marbleBlockDAL.GetList();
        }

        public void TInsert(MarbleBlock t)
        {
            _marbleBlockDAL.Insert(t);
        }

        public void TUpdate(MarbleBlock t)
        {
            _marbleBlockDAL.Update(t);
        }
    }
}
