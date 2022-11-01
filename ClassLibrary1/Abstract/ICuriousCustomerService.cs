using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICuriousCustomerService
    {
        IResult Add(CuriousCustomer curiousCustomer);
        IResult Update(CuriousCustomer curiousCustomer);
        IResult Delete(string Id);
        IDataResult<List<CuriousCustomer>> GetAll();
        IDataResult<CuriousCustomer> GetById(int productId);


    }
}
