using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alfred.Application.UseCases.RegisterSubscriber
{
    //We need an interface so we can utilize dependency injection
    public interface IRegisterSubscriber
    {
         Task Register(string name, string phoneNumber);
    }
}
