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
    public class Session:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CustomerInfo { get; set; }
        public string Participant { get; set; }
        public string SessionSubject { get; set; }
        public string SessionResult { get; set; }
        public string SessionTitle { get; set; }
    }
}
