using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class ForeignInvestorDto
    {
        public string ForeignInvestorName { get; set; }
        public string ForeignInvestorLastName { get; set; }
        public long ForeignInvestorPhoneNumber { get; set; }
        public string ForeignInvestorEMail { get; set; }
        public string ForeignInvestorAddress { get; set; }
        public string ForeignInvestorCompany { get; set; }
        public string ForeignInvestorPosition { get; set; }
        public string ForeignInvestorNote { get; set; }
        public string ForeignInvestorCountry { get; set; }
        public DateTime ForeignInvestorDateTime { get; set; }
    }
}
