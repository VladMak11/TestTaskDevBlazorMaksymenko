using BlazorAppModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppModels.ViewModel
{
    public class PropertyVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime PurchaseDateTime { get; set; }
        [Required]
        public decimal InitialValue { get; set; }
        [Required]
        public string DepreciationPeriod { get; set; }
        [Required]
        public decimal DepreciationValue { get; set; }
        public decimal CurrentValue { get; set; }
    }
}
