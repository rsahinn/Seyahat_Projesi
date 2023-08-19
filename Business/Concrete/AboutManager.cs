using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }
        public List<About> GetAll()
		{
			return _aboutdal.GetAll();
		}

		public List<About> GetAll(int id)
		{
			return _aboutdal.GetAll(x => x.AboutId == id);
		}

		public void TAdd(About entity)
		{
			_aboutdal.Add(entity);
		}

		public void TDelete(About entity)
		{
			_aboutdal.Delete(entity);
		}

		public About TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(About entity)
		{
			_aboutdal.Update(entity);
		}
	}
}
