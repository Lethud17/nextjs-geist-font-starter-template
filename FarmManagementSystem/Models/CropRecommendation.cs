using System.ComponentModel.DataAnnotations;

namespace FarmManagementSystem.Models
{
    public class CropRecommendation
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Soil Type")]
        public string SoilType { get; set; } = string.Empty;
        
        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; } = string.Empty;
        
        [Required]
        [Display(Name = "Expected Yield (tons)")]
        [Range(0.1, 1000, ErrorMessage = "Yield must be between 0.1 and 1000 tons")]
        public double YieldData { get; set; }
        
        [Display(Name = "Climate")]
        public string Climate { get; set; } = string.Empty;
        
        [Display(Name = "Farm Size (acres)")]
        public double FarmSize { get; set; }
        
        [Display(Name = "AI Recommendation")]
        public string Recommendation { get; set; } = string.Empty;
        
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}
