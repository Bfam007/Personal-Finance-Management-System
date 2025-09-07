using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        void AddNotification(Notification notification);
        List<Notification> GetAllNotification();
        Notification GetNotification(int Id);
        List<Notification> GetNotificationByUser(int UserId);
        Notification GetNotificationByType(string Type);



    }
}
