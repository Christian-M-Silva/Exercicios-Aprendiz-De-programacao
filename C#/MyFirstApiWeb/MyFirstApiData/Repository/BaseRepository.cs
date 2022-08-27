using Microsoft.EntityFrameworkCore;
using MyFirstApiData.Context;
using MyFirstApiDomain.Entities;
using MyFirstApiDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstApiData.Repository{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntitie {

        protected readonly MyContext _context;
        private DbSet<T> _dataset;

        public BaseRepository(MyContext context) {
            _context = context;
            _dataset = _context.Set<T> ();
        }

        public async Task<bool> DeleteAsync(Guid id) {
            try {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null) {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception err) {

                throw err;
            }
        }

        public async Task<T> InsertAsync(T item) {
            try {
                if (item.Id == Guid.Empty) {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception error) {

                throw error;
            }

            return item;
        }

        public async Task<T> SelectAsync(Guid id) {
            try {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception err) {

                throw err;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync() {
            try {
                return await _dataset.ToListAsync();
            }
            catch (Exception err) {

                throw err;
            }
        }

        public async Task<T> UpdateAsync(T item) {
            try {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) {
                    return null;
                }

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception err) {

                throw err;
            }

            return item;
        }
    }
}
