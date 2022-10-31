using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Databases.MongoDB
{
    public class MongoDB_PossibleCustomerDal: MongoDB_RepositoryBase<PossibleCustomer, MongoDB_Context<PossibleCustomer, MongoDB_PossibleCustomerCollection>>, IPossibleCustomerDal
    {
    }
}
