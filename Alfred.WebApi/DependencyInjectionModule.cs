using Alfred.Application.Repositories;
using Alfred.Application.UseCases.RegisterSubscriber;
using Alfred.Infrastructure.Repositories.EntityFramework;
using Autofac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  EFInfra = Alfred.Infrastructure.Repositories.EntityFramework;

namespace Alfred.WebApi
{
    public class DependencyInjectionModule : Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            ConnectionString = @"Server=CALVINMANN505B\\SQLEXPRESS;Database=ArbitrageSearch;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.RegisterType<EFInfra.SubscriberRepository>().As<ISubscriberWriteOnlyRepository>();
            builder.RegisterType<RegisterSubscriberAppService>().As<IRegisterSubscriberAppService>();
            //builder.RegisterType<>().As<IAccountWriteOnlyRepository>

            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);

            builder.RegisterType<AlfredDbContext>()
              .WithParameter(new TypedParameter(typeof(DbContextOptions), optionsBuilder.Options))
              .InstancePerLifetimeScope();

        }
    }
}
