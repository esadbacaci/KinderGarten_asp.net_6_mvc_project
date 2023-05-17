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
    public class KayitformManager : IKayitformService
    {
        IKayitformDal _kayitformDal;

        public KayitformManager(IKayitformDal kayitformDal)
        {
            _kayitformDal = kayitformDal;
        }

        public List<KayitForm> GetList()
        {
          return _kayitformDal.GetListAll();
        }

        public void TAdd(KayitForm t)
        {
            _kayitformDal.Insert(t);
        }

        public void TDelete(KayitForm t)
        {
            _kayitformDal.Delete(t);
        }

        public KayitForm TGetById(int id)
        {
           return _kayitformDal.GetByID (id);
        }

        public void TUpdate(KayitForm t)
        {
            _kayitformDal.Update(t);
        }
    }
}
