using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    //Every request should have a start time and state
    public interface IRequest
    {
        Id SubscriberId { get; }

        DateTime RequestStartTime { get; }

        RequestState StateOfRequest { get; }
    }
}
