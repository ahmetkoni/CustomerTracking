using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class PossibleCustomerDto
    {
        public int ProductId { get; set; }
        public string PossibleCustomerName { get; set; }
        public string PossibleCustomerLastName { get; set; }
        public string PossibleCustomerPhone { get; set; }
        public string PossibleCustomerEMail { get; set; }
        public string PossibleCustomerAddress { get; set; }
        public string PossibleCustomerCommpany { get; set; }
        public string PossibleCustomerPosition { get; set; }
        public string PossibleCustomerNote { get; set; }
        public DateTime CustomerDateTime { get; set; }
    }
}
