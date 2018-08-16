using Alfred.Application.UseCases.RegisterSubscriber;
using System;
using Xunit;

namespace Alfred.Application.Tests
{
    public class RegisterSubscriberTests
    {
        [Fact]
        public void Exception_should_throw_if_name_is_bad()
        {
            //Arrange
            IRegisterSubscriber registerSubscriber = new RegisterSubscriber();

            //Act


            //Assert
            Assert.Throws<Exception>(() => registerSubscriber.Register("", "702-338-0362"));
        }

        [Fact]
        public void Exception_should_throw_if_phone_is_bad()
        {
            //Arrange
            IRegisterSubscriber registerSubscriber = new RegisterSubscriber();

            //Act


            //Assert
            Assert.Throws<Exception>(() => registerSubscriber.Register("Calvin Mann", ""));
        }
    }
}
