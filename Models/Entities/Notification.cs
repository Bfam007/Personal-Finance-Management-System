namespace PFMApp.Models.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NotificationType { get; set; }
        public string NotificationContent { get; set; }
        public DateTime NotificationDate { get; set; }
        
    }
}
