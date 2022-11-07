using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [SecuredOperation("product.add,admin")]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(string Id)
        {
            var customer = _customerDal.Get(c => c.Id == Id);
            _customerDal.Delete(customer);
            return new SuccessDataResult<List<Customer>>(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public IDataResult<List<Customer>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p=>p.Price >= min && p.Price <= max));
        }

        public IResult Update(Customer customer)
        { 
            _customerDal.Update(customer);
            return new SuccessDataResult<List<Customer>>(Messages.CustomerUpdated);
        }
    }
}
