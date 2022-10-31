using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISessionService
    {
        IResult Add(Session session);
        IResult Delete(Session session);
        IResult Update(Session session);
    }
}
