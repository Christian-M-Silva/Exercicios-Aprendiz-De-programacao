using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Director.Service {
    public interface ILoginService {

        Task<bool> FindByLoginService(string email);
    }
}
