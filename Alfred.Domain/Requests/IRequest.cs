using Alfred.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    //Every request should have a state
    public interface IRequest
    {
  
        RequestState StateOfRequest { get; }
        DateTime RequestCreatedDate { get; }
    }
}
