using Alfred.Domain.ValueObjects;
using System;

namespace Alfred.Domain.Accounts
{
    public interface IAccount
    {
        bool IsAccountEnabled { get; }
        Id SubscriberId { get; }

        void Subscribe();
        void AddReminder();
        void DisableAccount();
        void EnableAccount();
    }
}