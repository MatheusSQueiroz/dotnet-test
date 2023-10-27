using donet_test.Model;
using Microsoft.EntityFrameworkCore;

namespace donet_test.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("tb_produtos");
        }

        public DbSet<Produto> Produtos { get; set; } = null!;

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var insertedEntries = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity);

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
