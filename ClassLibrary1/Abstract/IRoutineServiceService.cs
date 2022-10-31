using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoutineServiceService
    {
        IResult Add(RoutineService routineService);
        IResult Delete(RoutineService routineService);
        IResult Update(RoutineService routineService);
        IDataResult<List<RoutineService>> GetAll();
        IDataResult<RoutineService> GetById(int productId);
        IDataResult<List<RoutineService>> GetAllById(int customerId);
    }
}
