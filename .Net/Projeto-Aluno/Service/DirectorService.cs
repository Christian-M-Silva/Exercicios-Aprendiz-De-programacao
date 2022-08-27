using Domain.Entites;
using Domain.Interface;
using Domain.Interface.Director.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service {
	public class DirectorService : IDirectorService {

		private IRepositoryBase<DirectorEntite> _repository;

		public DirectorService(IRepositoryBase<DirectorEntite> repository) {
			_repository = repository;   
		}

		public async Task<bool> Delete(Guid id) {
			return await _repository.DeleteAsync(id);
		}

		public async Task<DirectorEntite> Get(Guid id) {
			return await _repository.SelectAsync(id);
		}

		public async Task<IEnumerable<DirectorEntite>> GetAll() {
			return await _repository.SelectAllAsync();
		}

		public async Task<DirectorEntite> Post(DirectorEntite director) {
			if (String.IsNullOrEmpty(director.Name) || director.Email.Contains(" ")) {
				return null;
            }
			return await _repository.InsertAsync(director);
		}

		public async Task<DirectorEntite> Put(DirectorEntite director) {
			return await _repository.UpdateAsync(director);
		}
	}
}
