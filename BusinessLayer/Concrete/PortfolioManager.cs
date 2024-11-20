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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfoliolDal;

        public PortfolioManager(IPortfolioDal portfoliolDal)
        {
            _portfoliolDal = portfoliolDal;
        }
        public List<Portfolio> GetList()
        {
            return _portfoliolDal.GetList();
        }

        public void TAdd(Portfolio t)
        {
            _portfoliolDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoliolDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfoliolDal.GetByID(id);
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            _portfoliolDal.Update(t);
        }
    }
}
