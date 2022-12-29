using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductService.Models
{
    public class Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}