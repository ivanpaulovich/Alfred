using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain
{
    //making this interface internal because only domain entities need to implement it
    internal interface IEntity
    {
        //Every Entity must have an ID
        Guid Id { get; }
    }
}
