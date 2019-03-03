using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly string nonValid;
        public InvalidCharsAttribute(string nonValid) :base("{0} contains unacceptable characters!")
        {
            this.nonValid = nonValid;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) {
                foreach (char c in nonValid) { 
                    if (value.ToString().IndexOf(c) != -1) {
                        var errormessage = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(errormessage);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}