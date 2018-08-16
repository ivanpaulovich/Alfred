using System;
using Alfred.Domain.ValueObjects;

namespace Alfred.Domain.Subscribers
{
    public interface ISubscriber
    {
        Name Name { get; }
        PhoneNumber PhoneNumber { get; }
       Id AccountId { get; }

        void SetAccountId(Id accountId);
    }
}