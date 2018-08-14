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
            Subscriber subscriber;
            Guid subID = Guid.NewGuid();
            Name name = "Calvin";
            PhoneNumber PhoneNumber = "702-338-0362";

            //Act
            subscriber = new Subscriber(name, PhoneNumber);

            //Assert
            Assert.True(subscriber.Id != Guid.Empty);
            Assert.Equal(subscriber.Name, name);
            Assert.Equal(subscriber.PhoneNumber, PhoneNumber);
        }

        

        }

    
}
