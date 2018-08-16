using System;
using System.Collections.Generic;
using System.Text;

namespace Alfred.Infrastructure.Repositories.EntityFramework.Entities
{
    public class Subscriber
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
