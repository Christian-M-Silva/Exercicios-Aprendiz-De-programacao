using MyFirstApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstApiDomain.Interfaces.Service.InterfaceUser {
    public interface IUserService {
        Task<User> Get(Guid id);
        Task<IEnumerable<User>> GetAll();
        Task<User> Post(User user);
        Task<User> Put(User user);
        Task<bool> Delete(Guid id);
    }
}
