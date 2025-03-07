namespace Meeting_Reminder_System.Models
{
    public class NotificationLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MeetingId { get; set; }
        public string Channel { get; set; }
        public string Status { get; set; }
    }
}
