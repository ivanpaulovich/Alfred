using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    //Every request should have a start time and state
    internal interface IRequest
    {

        DateTime RequestStartTime { get; }

        RequestState StateOfRequest { get; }
    }
}
