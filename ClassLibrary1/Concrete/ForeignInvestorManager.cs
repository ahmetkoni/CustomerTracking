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
    public class ForeignInvestorManager : IForeignInvestorService
    {
        IForeignInvestorDal _foreignInvestorDal;
        public ForeignInvestorManager(IForeignInvestorDal foreignInvestorDal)
        {
            _foreignInvestorDal = foreignInvestorDal;
        }

        public IResult Add(ForeignInvestor foreignInvestor)
        {
            _foreignInvestorDal.Add(foreignInvestor);
            return new SuccessResult(Messages.ForeignInvestorAdded);
        }

        public IResult Delete(string Id)
        {
            var foreignInvestor = _foreignInvestorDal.Get(f => f.Id == Id);
            _foreignInvestorDal.Delete(foreignInvestor);
            return new SuccessDataResult<List<ForeignInvestor>>(Messages.ForeignInvestorDeleted);
        }

        public IDataResult<List<ForeignInvestor>> GetAll()
        {
            return new SuccessDataResult<List<ForeignInvestor>>(_foreignInvestorDal.GetAll(),Messages.ForeignInvestorListed);
        }

        public IResult Update(ForeignInvestor foreignInvestor)
        {
            _foreignInvestorDal.Update(foreignInvestor);
            return new SuccessDataResult<List<ForeignInvestor>>(Messages.ForeignInvestorUpdated);
        }
    }
}
