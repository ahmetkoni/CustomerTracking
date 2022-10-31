using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ForeignInvestor:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
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
