using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.Requests
{
    public enum RequestState
    {
        Opened,
        Set,
        Completed,
        Cancelled
    }
}
