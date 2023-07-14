using BlazorAppModels.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppModels.ModelHelper
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userManager = (UserManager<ApplicationUser>)validationContext.GetService(typeof(UserManager<ApplicationUser>));
            var userEmail = (string)value;
            var existingUser = userManager.FindByEmailAsync(userEmail).Result;

            if (existingUser != null)
            {
                return new ValidationResult($"User with email {userEmail} already exists.");
            }

            return ValidationResult.Success;
        }
    }
}
