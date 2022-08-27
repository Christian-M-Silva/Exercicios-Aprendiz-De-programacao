using MyFirstApiDomain.Entities;
using MyFirstApiDomain.Interfaces;
using System.Threading.Tasks;

namespace MyFirstApiDomain.Repository {
    public interface IUserRepository : IRepository<User> {
        Task<User> FindByLogin(string email);
    }
}
