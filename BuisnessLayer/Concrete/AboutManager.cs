using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _abaoutDal;

		public AboutManager(IAboutDal abaoutDal)
		{
			_abaoutDal = abaoutDal;
		}

		public void Delete(About t)
		{
			_abaoutDal.Delete(t);
		}

		public About GetById(int id)
		{
			return _abaoutDal.GetById(id);
		}

		public List<About> GetListAll()
		{
			return _abaoutDal.GetListAll();
		}

		public void Insert(About t)
		{
			_abaoutDal.Insert(t);
		}

		public void Update(About t)
		{
			_abaoutDal.Update(t);
		}
	}
}
