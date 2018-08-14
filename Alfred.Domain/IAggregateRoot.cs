using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain
{
    //Every aggregate root will be an entity with a unique ID
    //This is left empty but the interface ensures that the implementing object is of type aggregate root
    //Left internal so only the domain objects can access this

        //Note: I suppose this could be an abstract class as well...
    internal interface IAggregateRoot : IEntity
    {
    }
}
