using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFirstApiData.Context;
using MyFirstApiData.Implementations;
using MyFirstApiData.Repository;
using MyFirstApiDomain.Interfaces;
using MyFirstApiDomain.Repository;

namespace MyFirstApiCrossCutting.InjectionDepedencia {
    public class ClassConfigureInjectionIRepository {
        public static void ConfigureInjectionIRepository(IServiceCollection ConfigureIrepositoryInjection) {
            ConfigureIrepositoryInjection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            ConfigureIrepositoryInjection.AddScoped<IUserRepository, ClassUserImplemantion>();

            ConfigureIrepositoryInjection.AddDbContext<MyContext>(options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=senha"));

        }
    }
}
