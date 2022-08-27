using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApiData.Context{

    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>{
        public MyContext CreateDbContext(string[] args) {
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=senha";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseMySql (connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}
