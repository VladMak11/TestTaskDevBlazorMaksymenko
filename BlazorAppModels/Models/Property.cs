using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppModels.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
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
    }
}
