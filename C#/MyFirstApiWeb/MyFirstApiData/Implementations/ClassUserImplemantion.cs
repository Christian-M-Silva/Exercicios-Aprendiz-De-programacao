using Microsoft.EntityFrameworkCore;
using MyFirstApiData.Context;
using MyFirstApiData.Repository;
using MyFirstApiDomain.Entities;
using MyFirstApiDomain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApiData.Implementations {
    public class ClassUserImplemantion : BaseRepository<User>, IUserRepository {

        private DbSet<User> _users;

        public ClassUserImplemantion(MyContext context) : base(context) {
            _users = context.Set<User>();
        }

        public async Task<User> FindByLogin(string email) {
            return await _users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
