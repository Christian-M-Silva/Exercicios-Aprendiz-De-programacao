using Domain.Entites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Student.IService {
    public interface IStudentService {
        Task<StudentEntite> Get(Guid id);

        Task<IEnumerable<StudentEntite>> GetAll();

        Task<bool> Delete(Guid id);

        Task<StudentEntite> Put(StudentEntite student);

        Task<StudentEntite> Post(StudentEntite student);
    }
}
