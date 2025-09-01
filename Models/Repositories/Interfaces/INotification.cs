using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface INotification
    {
        void AddNotification(Notification notification);
        List<Notification> GetAllNotification();
        Notification GetNotification(int Id);
        Notification GetNotificationById(int UserId);
        Notification GetNotificationByType(string Type);



    }
}
