using Alfred.Domain.Requests.Reminders;
using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Accounts
{
    //An Aggregate is a transactional consistency boundary
    public sealed class Account : IAggregateRoot, IAccount
    {
        public Id Id { get; private set; }
        public Id SubscriberId { get; private set; }
        public bool IsAccountEnabled { get; private set; }

        public Account(Id subscriberID)
        {
            Id = Guid.NewGuid();
            SubscriberId = subscriberID;
            IsAccountEnabled = true;
        }

        //Disable the account
        public void DisableAccount()
        {
            IsAccountEnabled = false;
        }

        public void EnableAccount()
        {
            IsAccountEnabled = true;
        }

        public void SubscribeToService(
            string serviceName)
        {
            // Add to a list of services
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }

        public void AddReminder()
        {
            throw new NotImplementedException();
        }
    }
}
