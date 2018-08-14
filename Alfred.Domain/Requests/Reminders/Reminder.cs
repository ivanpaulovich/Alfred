using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests.Reminders
{
    public class Reminder : Request
    {
  
        public Guid SubscriberId { get; private set; }

        
        public Reminder(Guid subscriberID):base()
        {
       
            SubscriberId = subscriberID;
        }
    }
}
