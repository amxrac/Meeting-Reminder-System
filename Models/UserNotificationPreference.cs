namespace Meeting_Reminder_System.Models
{
    public class UserNotificationPreference
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Channel { get; set; }
    }
}
