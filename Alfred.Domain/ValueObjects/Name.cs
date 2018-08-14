using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Domain.ValueObjects
{
    //I sealed the class so it cant be inherited
    public sealed class Name
    {
        private string _text;

        //Here we check that the string is valid and throw an exception if it isnt. 
        //This is done so that any class that uses this value object can ensure that the value is always in a true state
        public Name(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new NameShouldNotBeEmptyException("The 'Name' field is required");

            _text = text;
        }

        //Use the impliciit operator to set the name just as you would a string
        public static implicit operator Name(string text)
        {
            return new Name(text);
        }

        //Use the impliciit operator to set the name just as you would a string
        public static implicit operator string(Name name)
        {
            return name._text;
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

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((Name)obj)._text == _text;
        }
    }
}
