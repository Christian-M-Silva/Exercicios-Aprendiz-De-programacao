using Domain.Interface.Director.Service;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class LoginService : ILoginService {

        private ILoginRepository _directorRepository;

        public LoginService(ILoginRepository directorRepository) {
            _directorRepository = directorRepository;
        }

        public async Task<bool> FindByLoginService(string email) {
            return await _directorRepository.FindEmail(email);
        }
    }
}
