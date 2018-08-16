using Alfred.Application.Repositories;
using Alfred.Application.UseCases.RegisterSubscriber;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Alfred.Application.Tests
{
    public class RegisterSubscriberTests
    {
        [Fact]
        public async Task Exception_should_throw_if_name_is_bad()
        {
            ////Arrange
            //var mockAccountWriteOnlyRepository = new Mock<IAccountWriteOnlyRepository>();
            //var mockSubscriberWriteOnlyRepository = new Mock<ISubscriberWriteOnlyRepository>();

            //IRegisterSubscriber registerSubscriber = new RegisterSubscriber(mockSubscriberWriteOnlyRepository, mockAccountWriteOnlyRepository);

            ////Act


            ////Assert
            //await Assert.ThrowsAsync<Exception>(() => registerSubscriber.Register("", "702-338-0362"));
        }

        [Fact]
        public async Task Exception_should_throw_if_phone_is_bad()
        {
            ////Arrange
            //IRegisterSubscriber registerSubscriber = new RegisterSubscriber();

            ////Act


            ////Assert
            //await Assert.ThrowsAsync<Exception>(() => registerSubscriber.Register("Calvin Mann", ""));
        }

        [Fact]
        public async void Exception_should_throw_if()
        {

        }
        }
}
