using Data.Context;
using Domain.Entites;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository {
    public class BaseRepository<Entite> : IRepositoryBase<Entite> where Entite : BaseEntites {

        protected readonly MyContext _context;
        private DbSet<Entite> _dbSet;

        public BaseRepository(MyContext context) {
            _context = context;
            _dbSet = context.Set<Entite>();
        }

        public async Task<bool> DeleteAsync(Guid Id) {
            try {
                var result = await _dbSet.SingleOrDefaultAsync(p => p.Id.Equals(Id));
                if (result == null) {
                    return false;
                }

                _dbSet.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception erro) {

                throw erro;
            }
        }

        public async Task<Entite> InsertAsync(Entite entite) {
            try {
                if (entite.Id == Guid.Empty) {
                    entite.Id = Guid.NewGuid();
                }

                entite.CreatAt = DateTime.UtcNow;

                _dbSet.Add(entite);
                await _context.SaveChangesAsync();
                return entite;
            }
            catch (Exception erro) {

                throw erro;
            }
        }

        public async Task<IEnumerable<Entite>> SelectAllAsync() {
            try {
                return await _dbSet.ToListAsync();
            }
            catch (Exception erro) {

                throw erro;
            }
        }

        public async Task<Entite> SelectAsync(Guid Id) {
            try {
                var result = await _dbSet.SingleOrDefaultAsync(p => p.Id.Equals(Id));

                if(result == null) {
                    return null;
                }

                return result;
            }
            catch (Exception erro) {

                throw erro;
            }
        }

        public async Task<Entite> UpdateAsync(Entite entite) {
            try {
                var result = await _dbSet.SingleOrDefaultAsync(p => p.Id.Equals(entite.Id));
                if (result == null) { 
                    return null;
                }

                entite.CreatAt = result.CreatAt;
                entite.UpdateAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(entite);
                await _context.SaveChangesAsync();
                return entite;
            }
            catch (Exception erro) {

                throw erro;
            }
        }
    }
}
