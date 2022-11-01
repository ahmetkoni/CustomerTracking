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
    public class RoutineServiceManager : IRoutineServiceService
    {
        IRoutineServiceDal _routineServiceDal;
        public RoutineServiceManager(IRoutineServiceDal routineServiceDal)
        {
            _routineServiceDal = routineServiceDal;
        }

        public IResult Add(RoutineService routineService)
        {
            _routineServiceDal.Add(routineService);
            return new SuccessResult(Messages.RoutineServiceAdded);
        }

        public IResult Delete(RoutineService routineService)
        {
            _routineServiceDal.Delete(routineService);
            return new SuccessResult();
        }

        public IDataResult<List<RoutineService>> GetAll()
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(),Messages.RoutineServiceListed);
        }

        public IDataResult<List<RoutineService>> GetAllById(int customerId)
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(c=>c.CustomerId==customerId));
        }

        public IDataResult<RoutineService> GetById(int productId)
        {
            return new SuccessDataResult<RoutineService>(_routineServiceDal.Get(p=>p.ProductId==productId));
        }

        public IResult Update(RoutineService routineService)
        {
            throw new NotImplementedException();
        }
    }
}
