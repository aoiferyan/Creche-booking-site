using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoife_Ryan_S00190488.Models
{   //THIS CODE IS ATTEMPTED VALIDATION BUT ISNT WORKING PROPERLY
    public class StartDateAttribute : ValidationAttribute, IClientModelValidator
    {

        protected override ValidationResult IsValid(object StartDate, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;


            if (Student.StartDate <= DateTime.Now)
            {
                return new ValidationResult("Must be a date in the past");
            }

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-StartDate", "Must be date in past");
        }
    }
}
