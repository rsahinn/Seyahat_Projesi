﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }

        public List<Destination> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
