using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentID { get; set; }
        public virtual int StudentID { get; set; }
        public virtual int CourseID { get; set; }
        [Required]
        [RegularExpression("[A-Fa-f]", ErrorMessage = "grade must be a letter between A and F")]
        public virtual char Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual bool IsActive { get; set; }
        [Required]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }
        [Required]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }
        [Required]
        [Range(2018, int.MaxValue, ErrorMessage = "Must be at least 2018")]
        public virtual int EnrollmentYear { get; set; }
    }
}