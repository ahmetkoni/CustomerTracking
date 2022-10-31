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
    public class SessionManager : ISessionService
    {
        ISessionDal _sessionDal;
        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }

        public IResult Add(Session session)
        {
            _sessionDal.Add(session);
            return new SuccessResult();
        }

        public IResult Delete(Session session)
        {
            _sessionDal.Delete(session);
            return new SuccessResult();
        }

        public IResult Update(Session session)
        {
            throw new NotImplementedException();
        }
    }
}
