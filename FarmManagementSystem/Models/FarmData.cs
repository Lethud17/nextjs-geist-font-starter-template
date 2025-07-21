using System.ComponentModel.DataAnnotations;

namespace FarmManagementSystem.Models
{
    public class FarmData
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Farm Name")]
        public string FarmName { get; set; } = string.Empty;
        
        [Required]
        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; } = string.Empty;
        
        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; } = string.Empty;
        
        [Display(Name = "Farm Size (acres)")]
        [Range(0.1, 10000, ErrorMessage = "Farm size must be between 0.1 and 10000 acres")]
        public double FarmSize { get; set; }
        
        [Display(Name = "Soil Type")]
        public string SoilType { get; set; } = string.Empty;
        
        [Display(Name = "Primary Crops")]
        public string PrimaryCrops { get; set; } = string.Empty;
        
        [Display(Name = "Annual Yield (tons)")]
        public double AnnualYield { get; set; }
        
        [Display(Name = "Established Date")]
        [DataType(DataType.Date)]
        public DateTime EstablishedDate { get; set; }
        
        [Display(Name = "User ID")]
        public string? UserId { get; set; }
        
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        
        [Display(Name = "Updated At")]
        public DateTime UpdatedAt { get; set; }
    }
}
