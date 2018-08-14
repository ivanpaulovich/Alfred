using Alfred.Domain.Accounts;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alfred.Domain.Tests
{
    public class AccountTests
    {
        //TESTING RULES
        //I first write tests so that they fail. 
        //After they fail, I go and add code that then makes them pass


        //BusinessRule: Every new account should have an subscriberID, ID, is Enabled
        [Fact]
        public void Account_should_have_ID_subscriberId_and_enabled()
        {
            //Arrange
            Account account;
            Guid subscriberId = Guid.NewGuid();

            //Act
            account = new Account(subscriberId);

            //Assert
            Assert.True(account.Id != Guid.Empty);
            Assert.True(account.SubscriberId != Guid.Empty);
            Assert.True(account.IsAccountEnabled);
        }

        //BusinessRule: Account can be disabled
        [Fact]
        public void Account_can_be_disabled()
        {
            //Arrange
            Account account;
            Guid subscriberId = Guid.NewGuid();

            //Act
            account = new Account(subscriberId);
            account.DisableAccount();

            //Assert
            Assert.True(account.IsAccountEnabled == false);
         
        }

        //BusinessRule: Account can be disabled
        [Fact]
        public void Account_can_be_enabled()
        {
            //Arrange
            Account account;
            Guid subscriberId = Guid.NewGuid();

            //Act
            account = new Account(subscriberId);
            account.EnableAccount();

            //Assert
            Assert.True(account.IsAccountEnabled);

        }

    }
}
