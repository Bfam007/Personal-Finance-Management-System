using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class NotificationRepository : INotificationRepository
    {
        public static List<Notification> NotificationList = [];
        public void AddNotification(Notification notification)
        {
            NotificationList.Add(notification);
        }

        public List<Notification> GetAllNotification()
        {
            var notificatio = NotificationList.ToList(); 
            return notificatio;
        }

        public Notification GetNotification(int Id)
        {
            var notification = NotificationList.Where(x => x.Id == Id).FirstOrDefault();
            return notification;
        }

        public List<Notification> GetNotificationByUser(int UserId)
        {
            var notification = NotificationList.Where(x => x.UserId == UserId).ToList();
            return notification;
        }

        public Notification GetNotificationByType(string Type)
        {
            var notification = NotificationList.Where(x => x.NotificationType == Type).FirstOrDefault();
            return notification;
        }
    }
}
