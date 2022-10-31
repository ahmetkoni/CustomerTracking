using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class MongoDBUpdate
    {
        public string Field { get; set; }
        public string NewValue { get; set; }
    }
}
