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
    public class HighlightsManager : IHighlightsService
    {
        IHighlightsDal _highlightsDal;

        public HighlightsManager(IHighlightsDal highlightsDal)
        {
            _highlightsDal = highlightsDal;
        }

        public List<Highlights> GetAll()
        {
            return _highlightsDal.GetAll();
        }

        public List<Highlights> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Highlights entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Highlights entity)
        {
            throw new NotImplementedException();
        }

        public Highlights TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Highlights entity)
        {
            throw new NotImplementedException();
        }
    }
}
