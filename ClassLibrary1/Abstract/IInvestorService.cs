using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInvestorService
    {
        IResult Add(Investor investor);
        IResult Update(Investor investor);
        IResult Delete(Investor investor);
        IDataResult<List<Investor>> GetAll();
    }
}
