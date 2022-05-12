using FluentValidation.Results;
using Gcsb.Connect.CleanArch.Application.Repositories;
using Domain = Gcsb.Connect.CleanArch.Domain.Commons;

namespace Gcsb.Connect.CleanArch.WebAPI.Notification
{
    public class NotificationContext : INotifications
    {
        public NotificationContext()
        {
            Notifications = new List<Domain::Notification>();
        }

        public List<Domain::Notification> Notifications { get; set; }

        public bool HasNotifications => Notifications.Any();

        public void AddNotification(string key, string message)
            => Notifications.Add(new Domain::Notification(key, message));

        public void AddNotifications(ValidationResult validationResult)
            => validationResult.Errors.ToList().ForEach(error => AddNotification(error.ErrorCode, error.ErrorMessage));
    }
}
