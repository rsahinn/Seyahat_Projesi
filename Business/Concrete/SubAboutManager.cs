using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public List<Entity.Concrete.SubAbout> GetAll()
        {
            return _subAboutDal.GetAll();
        }

        public List<Entity.Concrete.SubAbout> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Entity.Concrete.SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Entity.Concrete.SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public Entity.Concrete.SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Entity.Concrete.SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
