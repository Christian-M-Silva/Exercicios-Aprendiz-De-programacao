using Domain.Entites;
using System;
using System.Threading.Tasks;

namespace Domain.Interface.Repository {
    public interface ILoginRepository : IRepositoryBase<DirectorEntite> {
        public Task<Boolean> FindEmail(string email);
    }
}
