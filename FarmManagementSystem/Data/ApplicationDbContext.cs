using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FarmManagementSystem.Models;

namespace FarmManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CropCalendar> CropCalendars { get; set; }
        public DbSet<DiseaseDiagnosis> DiseaseDiagnoses { get; set; }
        public DbSet<CropRecommendation> CropRecommendations { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<FarmData> FarmDatas { get; set; }
    }
}
