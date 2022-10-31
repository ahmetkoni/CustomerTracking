using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class InvestorDto
    {
        public string InvestorName { get; set; }
        public string InvestorLastName { get; set; }
        public long InvestorPhoneNumber { get; set; }
        public string InvestorEMail { get; set; }
        public string InvestorAddress { get; set; }
        public string InvestorCompany { get; set; }
        public string InvestorPosition { get; set; }
        public string InvestorNote { get; set; }
        public DateTime InvestorDateTime { get; set; }
    }
}
