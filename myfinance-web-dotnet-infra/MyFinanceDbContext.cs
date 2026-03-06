using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDbContext : DbContext
{

    public DbSet<PlanoConta> PlanoConta { get; set; }
    public DbSet<Transacao> Transacao { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
        
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("A variável de ambiente 'DATABASE_CONNECTION_STRING' não foi configurada.");
        }
        
        optionsBuilder.UseSqlServer(connectionString);
    }
}
