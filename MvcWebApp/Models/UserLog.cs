using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MvcMongoApp.Models
{
    public class UserLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("IpAddress")]
        public string IpAddress { get; set; }

        [BsonElement("VisitDateTime")]
        public DateTime VisitDateTime { get; set; }
    }
}
