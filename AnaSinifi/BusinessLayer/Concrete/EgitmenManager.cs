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
    public class EgitmenManager : IEgitmenService
    {
        IEgitmenDal _egitmenDal;

        public EgitmenManager(IEgitmenDal egitmenDal)
        {
            _egitmenDal = egitmenDal;
        }

        public List<Egitmenler> GetList()
        {
            return _egitmenDal.GetListAll();
        }

        public void TAdd(Egitmenler t)
        {
            _egitmenDal.Insert(t);
        }

        public void TDelete(Egitmenler t)
        {
            _egitmenDal.Delete(t);
        }

        public Egitmenler TGetById(int id)
        {
           return _egitmenDal.GetByID(id);
        }

        public void TUpdate(Egitmenler t)
        {
            _egitmenDal.Update(t);
        }
    }
}
