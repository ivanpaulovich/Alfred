using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Alfred.Domain.ValueObjects
{
    public sealed class PhoneNumber
    {
        private string _text;

        //Here we check that the string is valid and throw an exception if it isnt. 
        //This is done so that any class that uses this value object can ensure that the value is always in a true state
        public PhoneNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new PhoneNumberShouldNotBeEmptyException("The 'PhoneNumber' field is required");

            string parseInst = @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$";
            Regex regex = new Regex(parseInst);
            Match match = regex.Match(text);

            if (!match.Success)
                throw new PhoneNumberShouldHaveFormattingException("Invalid phone format.");


            _text = text;
        }

        //Use the impliciit operator to set the name just as you would a string
        public static implicit operator PhoneNumber(string text)
        {
            return new PhoneNumber(text);
        }

        //Use the impliciit operator to set the name just as you would a string
        public static implicit operator string(PhoneNumber name)
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

            return ((PhoneNumber)obj)._text == _text;
        }
    }
}
