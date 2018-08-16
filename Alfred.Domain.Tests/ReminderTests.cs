using Alfred.Domain.Requests;
using Alfred.Domain.Requests.Reminders;
using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alfred.Domain.Tests
{
    public class ReminderTests
    {
        [Fact]
        public void NewReminder_should_have_ID_and_subscriberId_and_startdate_and_state()
        {
            //Arrange
            Reminder reminder;
            Id subscriberId = Guid.NewGuid();

            //Act
            reminder = new Reminder(subscriberId);

            //Assert
            Assert.True(reminder.Id != Guid.Empty);
            Assert.True(reminder.RequestStartTime != null);
            Assert.Equal( RequestState.Opened, reminder.StateOfRequest);
            Assert.Equal(reminder.SubscriberId, subscriberId);
        }
    }
}
