using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class MongoDBIndex
    {
        public int v { get; set; }
        public Dictionary<string, int> key { get; set; }
        public string name { get; set; }
    }
}
