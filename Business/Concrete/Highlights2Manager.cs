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
    public class Highlights2Manager : IHighligths2Service
    {
        IHighlights2Dal _highlights2Dal;

        public Highlights2Manager(IHighlights2Dal highlights2Dal)
        {
            _highlights2Dal = highlights2Dal;
        }

        public List<Highlights2> GetAll()
        {
           return _highlights2Dal.GetAll();
        }

        public List<Highlights2> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Highlights2 entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Highlights2 entity)
        {
            throw new NotImplementedException();
        }

        public Highlights2 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Highlights2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
