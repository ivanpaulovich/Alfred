using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests.Reminders
{
    public class Reminder : Request
    {
  
        public Reminder(Guid subscriberID):base(subscriberID)
        {
       
        }
    }
}
