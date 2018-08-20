using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests.Reminders
{
    public class Reminder : IRequest, IEntity
    {
        public DateTime RequestStartTime { get; private set; }
        public Id Id { get; private set; }
        public Id SubscriberId { get; private set; }
        public RequestState StateOfRequest
        {
            get
            {
                return _stateManager.StateOfRequest;
            }
        }

        private StateManager _stateManager;

        private Reminder() { }

        public Reminder(TimeSpan minutes, string message)
        {
            DateTime now = DateTime.UtcNow;
            RequestStartTime = now.Add(minutes);

            //_stateManager.SetState(New);

            //_stateManager.SetState(DelayOnce);

            //_stateManager.SetState(DelayTwo);

            //_stateManager.SetState(DelayClose);
        }

        public static Reminder CreateReminder(
            Id id,
            StateManager stateManager,
            DateTime requestStartTime,
            Id subscriberId)
        {
            Reminder reminder = new Reminder();
            reminder._stateManager = stateManager;
            reminder.Id = id;
            reminder.RequestStartTime = requestStartTime;
            reminder.SubscriberId = subscriberId;
            return reminder;
        }

        public Reminder(Id subscriberID)
        {
       
        }
    }
}
