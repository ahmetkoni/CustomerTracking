using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IForeignInvestorService
    {
        IResult Add(ForeignInvestor foreignInvestor);
        IResult Delete(ForeignInvestor foreignInvestor);
        IResult Update(ForeignInvestor foreignInvestor);
        IDataResult<List<ForeignInvestor>> GetAll();
    }
}
