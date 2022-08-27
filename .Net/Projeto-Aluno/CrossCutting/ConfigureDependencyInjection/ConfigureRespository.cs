using Data.Context;
using Data.Repository;
using Domain.Interface;
using Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CrossCutting.ConfigureDependencyInjection {
    public class ConfigureRespository {
        public static void ConfigureDepedencieRepository(IServiceCollection serviceCollection) {
            serviceCollection.AddScoped(typeof(IRepositoryBase<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<ILoginRepository, DirectorRepository>();
            //aqui é add scoped porque aqui irá trabalhar com o BD
            //e sempre que uma interface vai ter uma instancia que trabalha com o bd
            //tem que ser Scoped, nesse caso por exemplo o repository usamos no data,
            //que por sua vez usa para trabalhar com o BD.

            serviceCollection.AddDbContext<MyContext>(
                    options => options.UseMySql("Server=localhost;Port=3306;Database=dbSchool;Uid=root;Pwd=senha")
            ); //Aqui eu cuido da conexão com meu BD
        }
    }
}
