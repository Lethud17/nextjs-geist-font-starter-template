using System.ComponentModel.DataAnnotations;

namespace FarmManagementSystem.Models
{
    public class DiseaseDiagnosis
    {
        public int Id { get; set; }
        
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; } = string.Empty;
        
        [Display(Name = "Diagnosis")]
        public string Diagnosis { get; set; } = string.Empty;
        
        [Display(Name = "Treatment Advice")]
        public string Advice { get; set; } = string.Empty;
        
        [Display(Name = "Confidence Score")]
        public float ConfidenceScore { get; set; }
        
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}
