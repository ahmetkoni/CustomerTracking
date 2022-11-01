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
            return new SuccessResult(Messages.SessionAdded);
        }

        public IResult Delete(string Id)
        {
            var session = _sessionDal.Get(s=>s.Id== Id);
            _sessionDal.Delete(session);
            return new SuccessDataResult<List<Session>>(Messages.SessionDeleted);
        }

        public IResult Update(Session session)
        {
            throw new NotImplementedException();
        }
    }
}
