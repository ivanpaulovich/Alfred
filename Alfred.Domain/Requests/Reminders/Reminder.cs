using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests.Reminders
{
    //Entities should represent identity and lifecycles
    public class Reminder : IReminder, IEntity
    {
        public Id Id { get; private set; }

        public RequestState StateOfRequest
        {
            get
            {
                return _stateManager.GetState();
            }
        }

        public DateTime RequestCreatedDate { get; private set; }

        private RequestStateManager _stateManager;

        private Reminder() { }

        
        public static Reminder CreateReminder(
            Id id,
            RequestStateManager stateManager,
            DateTime requestStartTime)
        {
            Reminder reminder = new Reminder();
            reminder._stateManager = stateManager;
            reminder.Id = id;
            reminder.RequestCreatedDate = DateTime.Now;
            return reminder;
        }

      
    }
}
