using Alfred.Application.Repositories;
using Alfred.Domain.Subscribers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alfred.Infrastructure.Repositories.EntityFramework
{
    public sealed class SubscriberRepository : ISubscriberWriteOnlyRepository
    {
     
        private readonly AlfredDbContext _context;

        //Here we set the DbContext for the subscriber repository letting us know which db to use
        public SubscriberRepository(AlfredDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //We're passing in a DOMAIN subscriber and then converting it to a EF Subscriber
        //We do this so we can manipulate the EF Subscriber and not touch the domain objects
        //This prevents any reference to EF in the domain project
        public async Task AddAsync(Subscriber subscriber)
        {
            Entities.Subscriber subscriberEF = new Entities.Subscriber()
            {
                Id = subscriber.Id,
                Name = subscriber.Name,
                PhoneNumber = subscriber.PhoneNumber
            };

            await _context.AddAsync(subscriberEF);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Subscriber subscriber)
        {
            Entities.Subscriber subscriberEF = new Entities.Subscriber()
            {
                Id = subscriber.Id,
                Name = subscriber.Name,
                PhoneNumber = subscriber.PhoneNumber
            };

            _context.Subscribers.Update(subscriberEF);
            await _context.SaveChangesAsync();
        }
    }
}
