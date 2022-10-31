using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InvestorManager : IInvestorService
    {
        IInvestorDal _ınvestorDal;
        public InvestorManager(IInvestorDal ınvestorDal)
        {
            _ınvestorDal = ınvestorDal;
        }

        public IResult Add(Investor investor)
        {
            _ınvestorDal.Add(investor);
            return new SuccessResult();
        }

        public IResult Delete(Investor investor)
        {
            _ınvestorDal.Delete(investor);
            return new SuccessResult();
        }

        public IDataResult<List<Investor>> GetAll()
        {
            return new SuccessDataResult<List<Investor>>(_ınvestorDal.GetAll());
        }

        public IResult Update(Investor investor)
        {
            throw new NotImplementedException();
        }
    }
}
