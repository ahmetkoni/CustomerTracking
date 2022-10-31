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
    public class RoutineService:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
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
