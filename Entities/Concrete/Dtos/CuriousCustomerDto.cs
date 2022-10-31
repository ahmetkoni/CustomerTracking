using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class CuriousCustomerDto
    {
        public int ProductId { get; set; }
        public string CuriousCustomerName { get; set; }
        public string CuriousCustomerLastName { get; set; }
        public long CuriousCustomerPhoneNumber { get; set; }
        public string CuriousCustomerEMail { get; set; }
        public string CuriousCustomerAddress { get; set; }
        public string CuriousCustomerCompany { get; set; }
        public string CuriousCustomerPosition { get; set; }
        public string CuriousCustomerNote { get; set; }
        public DateTime CuriousCustomerDateTime { get; set; }
    }
}
