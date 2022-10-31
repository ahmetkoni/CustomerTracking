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
            return new SuccessResult();
        }

        public IResult Delete(ForeignInvestor foreignInvestor)
        {
            _foreignInvestorDal.Delete(foreignInvestor);
            return new SuccessResult();
        }

        public IDataResult<List<ForeignInvestor>> GetAll()
        {
            return new SuccessDataResult<List<ForeignInvestor>>(_foreignInvestorDal.GetAll());
        }

        public IResult Update(ForeignInvestor foreignInvestor)
        {
            throw new NotImplementedException();
        }
    }
}
