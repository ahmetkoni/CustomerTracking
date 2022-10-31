using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class RoutineServiceDto
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string RoutineServiceDescription { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public string Employee { get; set; }
    }
}
