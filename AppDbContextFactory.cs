using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using CommunityApp.Api.Data;

namespace CommunityApp.Api.Data

{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = "server=localhost;port=3306;database=communityappdb;user=root;password=cricket";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
