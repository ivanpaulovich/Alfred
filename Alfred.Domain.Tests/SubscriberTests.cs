using System;
using Xunit;
using Alfred.Domain;
using Alfred.Domain.Subscribers;
using Alfred.Domain.ValueObjects;
using Alfred.Domain.Accounts;

namespace Alfred.Domain.Tests
{
    public class SubscriberTests
    {
        //TESTING RULES
        //I first write tests so that they fail. 
        //After they fail, I go and add code that then makes them pass



        //BusinessRule: Every Subscriber should have a name, phone number, and ID
        [Fact]
        public void Subscriber_Should_Have_Name_PhoneNumber_and_ID()
        {
            //Arrange
            Account account;
            Subscriber subscriber;
            Guid subID = Guid.NewGuid();
            Name name = "Calvin";
            PhoneNumber PhoneNumber = "702-338-0362";

            //Act

            subscriber = new Subscriber(name, PhoneNumber);
            account = new Account(subscriber.Id);

            //Assert
            Assert.True(subscriber.Id != Guid.Empty);
            Assert.Equal(subscriber.Name, name);
            Assert.Equal(subscriber.PhoneNumber, PhoneNumber);
        }

        //BusinessRule: Every Subscriber should have a name, phone number, and ID
        [Fact]
        public void Subscriber_should_have_account_added_upon_creation()
        {
            //Arrange
            Account account;
            Subscriber subscriber;
            Guid subID = Guid.NewGuid();
            Name name = "Calvin";
            PhoneNumber PhoneNumber = "702-338-0362";

            //Act

            subscriber = new Subscriber(name, PhoneNumber);
            account = new Account(subscriber.Id);

            subscriber.AddAccount(account.Id);

            //Assert
            Assert.True(subscriber.AccountId != Guid.Empty);

        }


        }
}
