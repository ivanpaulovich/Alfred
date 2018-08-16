using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Application.Repositories
{
    //We declare the repository abstractions here. This way any repository framework can use the abstraction
    //And we have no direct dependency in the application layer to any frameworks
    public interface IAccountWriteOnlyRepository
    {
    }
}
