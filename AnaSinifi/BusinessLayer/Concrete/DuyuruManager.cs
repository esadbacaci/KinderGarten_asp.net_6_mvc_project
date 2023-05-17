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
	public class DuyuruManager : IDuyuruService
	{
		IDuyuruDal _duyuruDal;

		public DuyuruManager(IDuyuruDal duyuruDal)
		{
			_duyuruDal = duyuruDal;
		}

		public List<Duyurular> GetList()
		{
			return _duyuruDal.GetListAll();
		}

		public void TAdd(Duyurular t)
		{
			_duyuruDal.Insert(t);
		}

		public void TDelete(Duyurular t)
		{
			_duyuruDal.Delete(t);
		}

		public Duyurular TGetById(int id)
		{
			return _duyuruDal.GetByID(id);
		}

		public void TUpdate(Duyurular t)
		{
			_duyuruDal.Update(t);
		}
	}
}
