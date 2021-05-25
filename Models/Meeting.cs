using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class Meeting
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public List<Participant> Participants { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int Id { get; set; }
    }

}

