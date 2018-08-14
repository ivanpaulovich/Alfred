using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Accounts
{
    public sealed class Account : IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Guid SubscriberId { get; private set; }
        public bool IsAccountEnabled { get; private set; }

        public Account(Guid subscriberID)
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
    }
}
