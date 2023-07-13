using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppModels.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? Address { get; set; }

        public decimal? InitialPropertyValueSum { get; set; }

        public decimal? CurrentPropertyValueSum { get; set; }
    }
}
