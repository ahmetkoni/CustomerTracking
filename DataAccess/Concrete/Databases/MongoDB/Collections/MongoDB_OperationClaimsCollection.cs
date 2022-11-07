using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Databases.MongoDB.Collections
{
    public class MongoDB_OperationClaimsCollection : ICollection
    {
        public MongoDB_OperationClaimsCollection()
        {
            CollectionName = "OperationClaims";
        }

        public string CollectionName { get; set; }
    }
}
