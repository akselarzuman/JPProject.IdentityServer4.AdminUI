using System;
using Jp.Domain.Commands.UserManagement;
using Jp.Domain.Core.Events;

namespace Jp.Domain.Events.UserManagement
{
    public class ProfileUpdatedEvent : Event
    {
        public UpdateProfileCommand Request { get; }

        public ProfileUpdatedEvent(long aggregateId,UpdateProfileCommand request)
        {
            AggregateId = aggregateId.ToString();
            Request = request;
        }
    }
}
