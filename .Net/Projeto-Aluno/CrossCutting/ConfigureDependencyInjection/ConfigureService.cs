using Domain.Interface.Director.Service;
using Domain.Interface.Student.IService;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace CrossCutting.ConfigureDependencyInjection {
    public class ConfigureService {

        public static void ConfigureDepedencieServices(IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IStudentService, StudentService>();
            serviceCollection.AddTransient<IDirectorService, DirectorService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
