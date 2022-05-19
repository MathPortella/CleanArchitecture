using FluentValidation.Results;
using System.Collections.Generic;
using Domain = Gcsb.Connect.CleanArch.Domain.Commons;

namespace Gcsb.Connect.CleanArch.Application.Repositories
{
    public interface INotifications
    {
        List<Domain::Notification> Notifications { get; set; }

        bool HasNotifications { get; }

        void AddNotification(string key, string message);

        void AddNotifications(ValidationResult validationResult);
    }
}
