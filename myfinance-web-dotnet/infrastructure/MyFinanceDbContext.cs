using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.infrastructure
{
    public class MyFinanceDbContext : DbContext 
    {
        public DbSet<PlanoConta> PlanoConta { get; set; }

        public DbSet<Transacao> Transacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost,1433;Database=myfinance;User Id=sa;Password=k$u$t7fN*+&PT29;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}