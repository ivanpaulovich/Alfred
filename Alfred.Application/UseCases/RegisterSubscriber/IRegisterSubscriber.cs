using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Application.UseCases.RegisterSubscriber
{
    //We need an interface so we can utilize dependency injection
    public interface IRegisterSubscriber
    {
        void Register(string name, string phoneNumber);
    }
}
