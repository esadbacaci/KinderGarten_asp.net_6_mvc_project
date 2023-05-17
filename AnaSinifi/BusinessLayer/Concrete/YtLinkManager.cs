using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YtLinkManager : IYtLinkService
    {
        IYtLinkDal _iytLinkDal;

        public YtLinkManager(IYtLinkDal iytLinkDal)
        {
            _iytLinkDal = iytLinkDal;
        }

        public List<YtLink> GetList()
        {
            return _iytLinkDal.GetListAll();
        }

        public void TAdd(YtLink t)
        {
            _iytLinkDal.Insert(t);
        }

        public void TDelete(YtLink t)
        {
            _iytLinkDal.Delete(t);  
        }

        public YtLink TGetById(int id)
        {
           return _iytLinkDal.GetByID(id);
        }

        public void TUpdate(YtLink t)
        {
            _iytLinkDal.Update(t);
        }
    }
}
