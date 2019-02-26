using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseID { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "Can not exceed 150 characters")]
        [Display(Name = "Course Title")]
        public virtual string Title { get; set; }
        [Display(Name = "Description")]
        public virtual string Decription { get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Must be between 1 and 4")]
        [Display(Name = "Number of Credits")]
        public virtual int Credits { get; set; }
    }
}