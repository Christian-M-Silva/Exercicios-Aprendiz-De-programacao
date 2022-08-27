using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface {
    public interface IRepositoryBase<Entite> where Entite : BaseEntites {
        Task<Entite> InsertAsync (Entite entite);

        Task<Entite> UpdateAsync (Entite entite); 

        Task<Boolean> DeleteAsync (Guid Id);

        Task<Entite> SelectAsync(Guid Id);

        Task<IEnumerable<Entite>> SelectAllAsync();
    }
}
