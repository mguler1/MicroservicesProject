using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourseServices.Catalog.Model
{
    public class Category
    {
        [BsonId]//Mongo Db Id olarak algılaması için kullanılan attribute
        [BsonRepresentation(BsonType.ObjectId)]//Id yi string olarak oluşturulması için kullanılan attribute
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
