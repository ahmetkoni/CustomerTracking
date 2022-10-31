using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class GroupCountAggregation : MongoDBAggregation
    {
        public int Count { get; set; }
        public List<object> Ids { get; set; }
        public string DDMId { get; set; }
    }
}
