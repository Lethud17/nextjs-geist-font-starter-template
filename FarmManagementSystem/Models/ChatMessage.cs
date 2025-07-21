using System.ComponentModel.DataAnnotations;

namespace FarmManagementSystem.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "User Message")]
        public string UserMessage { get; set; } = string.Empty;
        
        [Display(Name = "AI Response")]
        public string BotResponse { get; set; } = string.Empty;
        
        [Display(Name = "Session ID")]
        public string SessionId { get; set; } = string.Empty;
        
        [Display(Name = "User ID")]
        public string? UserId { get; set; }
        
        [Display(Name = "Timestamp")]
        public DateTime TimeStamp { get; set; }
        
        [Display(Name = "Message Type")]
        public string MessageType { get; set; } = "General"; // General, CropAdvice, DiseaseHelp, etc.
    }
}
