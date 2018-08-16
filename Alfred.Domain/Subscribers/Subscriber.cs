using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Subscribers
{
    //The subscriber is our aggregate root
    //No need for an ISubscriber interface since no other entity will be a subscriber
    public sealed class Subscriber : IAggregateRoot, ISubscriber
    {
        public Id Id { private set;  get; }
        public Name Name { private set; get; }
        public PhoneNumber PhoneNumber { private set; get; }
        public Id AccountId { private set; get; }

        private Subscriber() { }

        public Subscriber(Name name, PhoneNumber phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;        
        }

        public void SetAccountId(Id accountId)
        {
            AccountId = accountId;
        }
    }
}
