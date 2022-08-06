using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Dtos
{
    public class CourseCreateDto
    {
       
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public string CourseUserId { get; set; }
        public string CoursePicture { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }

      

    }
}
