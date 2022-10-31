using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class SessionDto
    {
        public string CustomerInfo { get; set; }
        public string Participant { get; set; }
        public string SessionSubject { get; set; }
        public string SessionResult { get; set; }
        public string SessionTitle { get; set; }
    }
}
