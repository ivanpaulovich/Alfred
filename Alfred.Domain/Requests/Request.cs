using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    //This request is abstract becuase there are different types of requests

    public  abstract class Request : IRequest, IAggregateRoot
    {
        //Here we set the start time and request state

        protected Request()
        {
            Id = Guid.NewGuid();
            RequestStartTime = DateTime.Now;
            StateOfRequest = RequestState.Opened;
        }
        public DateTime RequestStartTime { get; private set; }

        public RequestState StateOfRequest { get; private set; }

        public Guid Id { get; private set; }

        protected void SetStateOfRequest(RequestState requestState)
        {
            StateOfRequest = requestState;
        }
    }
}
