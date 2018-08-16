using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.ValueObjects
{
    //I sealed the class so it cant be inherited
    public sealed class Id
    {
        private Guid _internalId;

        //Here we check that the Guid is valid and throw an exception if it isnt. 
        //This is done so that any class that uses this value object can ensure that the value is always in a true state
        public Id(Guid id)
        {
            if (id == null || id == Guid.Empty )
                throw new GuidShouldNotBeEmptyException("The 'Name' field is required");

            _internalId = id;
        }

        //Use the impliciit operator to set the Guid just as you would a primitive type
        public static implicit operator Id(Guid id)
        {
            return new Id(id);
        }

        //Use the impliciit operator to set the Guid just as you would a primitive type
        public static implicit operator Guid(Id id)
        {
            return id._internalId;
        }


        //First check reference and then check the string text to ensure that these objects are the same
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is Guid)
            {
                return obj.ToString() == _internalId.ToString();
            }

            return ((Id)obj)._internalId == _internalId;
        }
    }
}
