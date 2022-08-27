using Domain.Entites;
using Domain.Interface;
using Domain.Interface.Student.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class StudentService : IStudentService {

        //Aqui eu posso aplicar minha regra de négocio, e chamar uma validação, mas não é bom fazer minhas validações aqui.

        private IRepositoryBase<StudentEntite> _repository;

        public StudentService(IRepositoryBase<StudentEntite> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id) {
            return await _repository.DeleteAsync(id);
        }

        public async Task<StudentEntite> Get(Guid id) {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<StudentEntite>> GetAll() {
            return await _repository.SelectAllAsync();
        }

        public async Task<StudentEntite> Post(StudentEntite student) {
            return await _repository.InsertAsync(student);
        }

        public async Task<StudentEntite> Put(StudentEntite student) {
            return await _repository.UpdateAsync(student);
        }
    }
}
