using Microsoft.Extensions.DependencyInjection;
using MyFirstApiDomain.Interfaces.Service.InterfaceUser;
using MyFirstApiService.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApiCrossCutting.InjectionDepedencia {
    public class ClassConfigureInjection {
        public static void ConfigureInjectionDepedencia(IServiceCollection serviceCollection) { 
            serviceCollection.AddTransient<IUserService, ClassUserService>();
            serviceCollection.AddTransient<IloginUser, ClassLoginService>();
        }
    }
}
