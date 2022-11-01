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
    public class CuriousCustomerManager : ICuriousCustomerService
    {
        ICuriousCustomerDal _curiousCustomerDal;
        public CuriousCustomerManager(ICuriousCustomerDal curiousCustomerDal)
        {
            _curiousCustomerDal = curiousCustomerDal;
        }

        public IResult Add(CuriousCustomer curiousCustomer)
        {
            _curiousCustomerDal.Add(curiousCustomer);
            return new SuccessResult(Messages.CuriousCustomerAdded);
        }

        public IResult Delete(string Id)
        {
            var curiousCustomer = _curiousCustomerDal.Get(c => c.Id == Id);
            _curiousCustomerDal.Delete(curiousCustomer);
            return new SuccessDataResult<List<CuriousCustomer>>();

        }

        public IDataResult<List<CuriousCustomer>> GetAll()
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(),Messages.CuriousCustomerListed);
        }

        public IDataResult<CuriousCustomer> GetById(int productId)
        {
            return new SuccessDataResult<CuriousCustomer>(_curiousCustomerDal.Get(c => c.ProductId == productId));
        }

        public IResult Update(CuriousCustomer curiousCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
