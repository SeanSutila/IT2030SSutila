using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class Student : IValidatableObject
    {
        [Display(Name = "Student ID")]
        public virtual int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        [StringLength(5, ErrorMessage = "Enter a 5 digit Zipcode")]
        public virtual string ZipCode { get; set; }
        [StringLength(2, ErrorMessage = "Enter a 2 digit State code")]
        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Address1 == Address2)
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }
            throw new NotImplementedException();
        }
    }
}