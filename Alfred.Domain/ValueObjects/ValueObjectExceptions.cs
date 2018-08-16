using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.ValueObjects
{
    //A layer of inheritance in case I need to add more to the custom exceptions
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage)
            : base(businessMessage)
        {
        }
    }

    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class NameShouldNotBeEmptyException : DomainException
    {
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class PhoneNumberShouldNotBeEmptyException : DomainException
    {
        internal PhoneNumberShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

   
    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class PhoneNumberShouldHaveFormattingException : DomainException
    {
        internal PhoneNumberShouldHaveFormattingException(string message)
            : base(message)
        { }
    }

    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class GuidShouldNotBeEmptyException : DomainException
    {
        internal GuidShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    

}
