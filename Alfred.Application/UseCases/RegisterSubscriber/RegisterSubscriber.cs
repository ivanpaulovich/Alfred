using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Application.UseCases.RegisterSubscriber
{
    //Seal the class
    public sealed class RegisterSubscriber : IRegisterSubscriber
    {
        public void Register(string name, string phoneNumber)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be null");

            if (string.IsNullOrEmpty(phoneNumber))
                throw new Exception("Phone number cannot be null");
        }
    }
}
