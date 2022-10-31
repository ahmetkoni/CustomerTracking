using Core.Utilities.Results;
using DataAccess.Concrete.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Utilities.ConnectionResolvers
{
    public class MongoDB_ConnectionHelper : IDatabase_ConnectionHelper
    {
        public IDataResult<DatabaseConnectionSettings> CheckBaseConnection()
        {
            return new SuccessDataResult<DatabaseConnectionSettings>(new DatabaseConnectionSettings { HostName = $"mongodb://asdasd"});
        }
    }
}
