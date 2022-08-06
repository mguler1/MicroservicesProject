using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Model
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal CoursePrice { get; set; }
        public string CourseUserId { get; set; }

        public string CoursePicture { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CourseCreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }

    }
}
