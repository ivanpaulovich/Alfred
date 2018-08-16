using Alfred.Application.Repositories;
using Alfred.Domain.Accounts;
using Alfred.Domain.Subscribers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alfred.Application.UseCases.RegisterSubscriber
{
    //Sealed the class
    public sealed class RegisterSubscriber : IRegisterSubscriber
    {
        private readonly ISubscriberWriteOnlyRepository _subscriberWriteOnlyRepository;
        private readonly IAccountWriteOnlyRepository _accountWriteOnlyRepository;

        //Dependency Injection will inject these classes
        public RegisterSubscriber(
            ISubscriberWriteOnlyRepository subscriberWriteOnlyRepository,
            IAccountWriteOnlyRepository accountWriteOnlyRepository)
        {
            _subscriberWriteOnlyRepository = subscriberWriteOnlyRepository;
            _accountWriteOnlyRepository = accountWriteOnlyRepository;
        }

        //QUESTION: Should I require value objects here? 
        public async Task Register(string name, string phoneNumber)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be null");

            if (string.IsNullOrEmpty(phoneNumber))
                throw new Exception("Phone number cannot be null");

            //Create the subscriber object
            Subscriber subscriber = new Subscriber(name, phoneNumber);

            //Create the account object
            Account account = new Account(subscriber.Id);

            //Set the referenced account in the subscriber
            subscriber.SetAccountId(account.Id);

            //start 
            await _subscriberWriteOnlyRepository.AddAsync(subscriber);

            //TODO: Add a return object for the presenter 
        }

        
    }
}
