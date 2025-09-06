using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class NotificationRepository : INotificationRepository
    {
        public void AddNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAllNotification()
        {
            throw new NotImplementedException();
        }

        public Notification GetNotification(int Id)
        {
            throw new NotImplementedException();
        }

        public Notification GetNotificationById(int UserId)
        {
            throw new NotImplementedException();
        }

        public Notification GetNotificationByType(string Type)
        {
            throw new NotImplementedException();
        }
    }
}
