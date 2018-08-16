using Alfred.Domain.Subscribers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alfred.Application.Repositories
{
    //We declare the repository abstractions here. This way any repository framework can use the abstraction
    //And we have no direct dependency in the application layer to any frameworks
    public interface ISubscriberWriteOnlyRepository
    {
        //TODO: Add note here about why we want to make these calls threaded
        Task AddAsync(Subscriber subscriber);
        Task Update(Subscriber subscriber);
    }
}
