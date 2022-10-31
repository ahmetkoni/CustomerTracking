using Core.Utilities.Results;
using DataAccess.Concrete.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Utilities.ConnectionResolvers
{
    public interface IDatabase_ConnectionHelper
    {
        IDataResult<DatabaseConnectionSettings> CheckBaseConnection();
    }
}
