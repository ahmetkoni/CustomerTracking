﻿using Business.Abstract;
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
    public class PossibleCustomerManager : IPossibleCustomerService
    {
        IPossibleCustomerDal _possibleCustomerDal;
        public PossibleCustomerManager(IPossibleCustomerDal possibleCustomerDal)
        {
            _possibleCustomerDal = possibleCustomerDal;
        }

        public IResult Add(PossibleCustomer possibleCustomer)
        {
            _possibleCustomerDal.Add(possibleCustomer);
            return new SuccessResult();
        }

        public IResult Delete(PossibleCustomer possibleCustomer)
        {
            _possibleCustomerDal.Delete(possibleCustomer);
            return new SuccessResult();
        }

        public IDataResult<List<PossibleCustomer>> GetAll()
        {
            return new SuccessDataResult<List<PossibleCustomer>>(_possibleCustomerDal.GetAll());
        }

        public IDataResult<PossibleCustomer> GetById(int productId)
        {
            return new SuccessDataResult<PossibleCustomer>(_possibleCustomerDal.Get(p=>p.ProductId == productId));
        }

        public IResult Update(PossibleCustomer possibleCustomer)
        {
            throw new NotImplementedException();
        }
    }
}