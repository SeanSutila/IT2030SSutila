using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Decription { get; set; }
        public virtual int Credits { get; set; }
    }
}