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
    public class TestiMonialManager : ITestiMonialService
    {
        ITestiMonialDal _testiMonialDal;

        public TestiMonialManager(ITestiMonialDal testiMonialDal)
        {
            _testiMonialDal = testiMonialDal;
        }

        public List<TestiMonial> GetAll()
        {
            return _testiMonialDal.GetAll();  
        }

        public List<TestiMonial> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(TestiMonial entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(TestiMonial entity)
        {
            throw new NotImplementedException();
        }

        public TestiMonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(TestiMonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
