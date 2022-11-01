using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPossibleCustomerService
    {
        IResult Add(PossibleCustomer possibleCustomer);
        IResult Delete(string Id);
        IResult Update(PossibleCustomer possibleCustomer);
        IDataResult<List<PossibleCustomer>> GetAll();
        IDataResult<PossibleCustomer> GetById(int productId);
    }
}
