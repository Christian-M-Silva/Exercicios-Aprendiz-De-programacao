using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface.Director.Service {
    public interface IDirectorService {
        Task<DirectorEntite> Get(Guid id);

        Task<IEnumerable<DirectorEntite>> GetAll();

        Task<bool> Delete(Guid id);

        Task<DirectorEntite> Put(DirectorEntite director);

        Task<DirectorEntite> Post(DirectorEntite director);
    }
}
