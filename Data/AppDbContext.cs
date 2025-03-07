using Meeting_Reminder_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Meeting_Reminder_System.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<NotificationLog> NotificationLogs { get; set; }
        public DbSet<UserNotificationPreference> userNotificationPreferences { get; set; }
    }
}
