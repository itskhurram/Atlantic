using Atlantic.MasterData.Domain;
using Microsoft.EntityFrameworkCore;

namespace Atlantic.MasterData.Data {
    public class MasterDataContext : DbContext {
        public MasterDataContext(DbContextOptions options) : base(options) {

        }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<BusinessServices> BusinessServices { get; set; }
    }
}
