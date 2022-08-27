using MyFirstApiDomain.Dtos;
using MyFirstApiDomain.Interfaces.Service.InterfaceUser;
using MyFirstApiDomain.Repository;
using System.Threading.Tasks;

namespace MyFirstApiService.Service {
    public class ClassLoginService : IloginUser {

        private IUserRepository _userRepository;

        public ClassLoginService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task<object> FindByLogin(DtoLogin users) {
            if (users != null && !string.IsNullOrWhiteSpace(users.Email)) {
                return await _userRepository.FindByLogin(users.Email);
            }else {
                return null;
            }
        }
    }
}
