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
    public class GaleriManager : IGaleriService
    {
        IGaleriDal _galeriDal;

        public GaleriManager(IGaleriDal galeriDal)
        {
            _galeriDal = galeriDal;
        }

        public List<Galeri> GetList()
        {
          return  _galeriDal.GetListAll();
        }

        public void TAdd(Galeri t)
        {
            _galeriDal.Insert(t);
        }

        public void TDelete(Galeri t)
        {
            throw new NotImplementedException();
        }

        public Galeri TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Galeri t)
        {
            throw new NotImplementedException();
        }
    }
}
