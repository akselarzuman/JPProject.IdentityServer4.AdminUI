using System;
using Jp.Domain.Core.Events;

namespace Jp.Domain.Events.UserManagement
{
    public class PasswordCreatedEvent : Event
    {

        public PasswordCreatedEvent(long aggregateId)
        {
            AggregateId = aggregateId.ToString();
        }
    }
}