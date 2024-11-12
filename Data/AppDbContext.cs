using EstoqueVendasSQLITE.Models;
using Microsoft.EntityFrameworkCore;

namespace EstoqueVendasSQLITE.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EntradaProduto> EntradaProduto { get; set; }
        public DbSet<SaidaProduto> SaidaProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<LoginModel> Login { get; set; }
    }
}
