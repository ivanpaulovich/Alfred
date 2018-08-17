using Alfred.Application.Repositories;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  EFInfra = Alfred.Infrastructure.Repositories.EntityFramework;

namespace Alfred.WebApi
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFInfra.SubscriberRepository>().As<ISubscriberWriteOnlyRepository>();
            //builder.RegisterType<>().As<IAccountWriteOnlyRepository>
        }
    }
}
