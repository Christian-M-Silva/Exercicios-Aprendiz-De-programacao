using MyFirstApiDomain.Dtos;
using MyFirstApiDomain.Entities;
using System.Threading.Tasks;

namespace MyFirstApiDomain.Interfaces.Service.InterfaceUser {
    public interface IloginUser {
        Task<object> FindByLogin(DtoLogin users);
    }
}
