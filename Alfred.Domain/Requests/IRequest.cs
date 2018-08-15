using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    //Every request should have a start time and state
    public interface IRequest
    {
        Guid SubscriberId { get; }

        DateTime RequestStartTime { get; }

        RequestState StateOfRequest { get; }
    }
}
