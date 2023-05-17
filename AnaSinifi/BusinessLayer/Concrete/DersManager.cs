using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        public List<Ders> GetList()
        {
          return _dersDal.GetListAll();
        }

        public void TAdd(Ders t)
        {
            _dersDal.Insert(t);
        }

        public void TDelete(Ders t)
        {
            _dersDal.Delete(t);
        }

        public Ders TGetById(int id)
        {
            return _dersDal.GetByID(id);
        }
		public List<Ders> GetDersById(int id)
		{
			return _dersDal.GetListAll(x => x.DersID == id);

		}
		public void TUpdate(Ders t)
        {
            throw new NotImplementedException();
        }
    }
}
