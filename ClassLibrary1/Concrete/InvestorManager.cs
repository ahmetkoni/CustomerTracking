using Business.Abstract;
using Business.Constants;
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
        IInvestorDal _investorDal;
        public InvestorManager(IInvestorDal investorDal)
        {
            _investorDal = investorDal;
        }

        public IResult Add(Investor investor)
        {
            _investorDal.Add(investor);
            return new SuccessResult(Messages.InvestorAdded);
        }

        public IResult Delete(string Id)
        {
            var investor = _investorDal.Get(i => i.Id == Id);
            _investorDal.Delete(investor);
            return new SuccessDataResult<List<Investor>>(Messages.InvestorDeleted);

        }

        public IDataResult<List<Investor>> GetAll()
        {
            return new SuccessDataResult<List<Investor>>(_investorDal.GetAll(),Messages.InvestorListed);
        }

        public IResult Update(Investor investor)
        {
            _investorDal.Update(investor);
            return new SuccessDataResult<List<Investor>>(Messages.InvestorUpdated);
        }
    }
}
