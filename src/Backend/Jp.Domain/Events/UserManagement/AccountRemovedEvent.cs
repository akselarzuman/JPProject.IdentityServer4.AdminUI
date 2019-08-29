﻿using System;
using Jp.Domain.Core.Events;

namespace Jp.Domain.Events.UserManagement
{
    public class AccountRemovedEvent : Event
    {
        public AccountRemovedEvent(long aggregateId)
        {
            AggregateId = aggregateId.ToString();
        }
    }
}