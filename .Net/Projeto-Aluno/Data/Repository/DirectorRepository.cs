using Data.Context;
using Domain.Entites;
using Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Data.Repository {
    public class DirectorRepository : BaseRepository<DirectorEntite>, ILoginRepository {
        
        private DbSet<DirectorEntite> _dbSet;
        
        public DirectorRepository(MyContext context) : base(context) {
            _dbSet = context.Set<DirectorEntite>();
        }

        public async Task<bool> FindEmail(string email) {
            var result = await _dbSet.SingleOrDefaultAsync(p => p.Email.Equals(email));

            if (result == null) { 
                return false;
            }

            return true;
        }
    }
}
