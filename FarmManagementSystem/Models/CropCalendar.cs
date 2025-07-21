using System.ComponentModel.DataAnnotations;

namespace FarmManagementSystem.Models
{
    public class CropCalendar
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Crop Type")]
        public string CropType { get; set; } = string.Empty;
        
        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; } = string.Empty;
        
        [Display(Name = "Optimal Planting Date")]
        public DateTime OptimalPlantingDate { get; set; }
        
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}
