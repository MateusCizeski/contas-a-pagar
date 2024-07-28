using api_contas_pagar.Models;
using Microsoft.EntityFrameworkCore;

namespace api_contas_pagar
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options) { }

        public DbSet<Fornecedor> fornecedores { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<FaturaPagamento> FaturaPagamentos { get; set; }
        public DbSet<MetodoPagamento> MetodosPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("fornecedores", "contas_pagar");

            modelBuilder.Entity<Fatura>()
               .HasOne(f => f.Fornecedor)
               .WithMany(f => f.Faturas)
               .HasForeignKey(f => f.CodigoFornecedor);

            modelBuilder.Entity<FaturaPagamento>()
                .HasKey(fp => new { fp.CodigoFatura, fp.CodigoPagamento });

            modelBuilder.Entity<FaturaPagamento>()
                .HasOne(f => f.Fatura)
                .WithMany(f => f.FaturaPagamentos)
                .HasForeignKey(f => f.CodigoFatura);

            modelBuilder.Entity<FaturaPagamento>()
                .HasOne(fp => fp.Pagamento)
                .WithMany(p => p.FaturaPagamentos)
                .HasForeignKey(fp => fp.CodigoPagamento);

            modelBuilder.Entity<Pagamento>()
                .HasOne(p => p.MetodoPagamento)
                .WithMany(m => m.Pagamentos)
                .HasForeignKey(p => p.CodigoMetodoPagamento);
        }
    }
}
