using api_contas_pagar.Models;
using Microsoft.EntityFrameworkCore;

namespace api_contas_pagar
{
    public class ContasAPagarContext : DbContext
    {
        public ContasAPagarContext(DbContextOptions<ContasAPagarContext> options) : base(options) { }
        
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Pagamento> Pagementos { get; set; }
        public DbSet<FaturaPagamento> FaturaPagementos { get; set; }
        public DbSet<MetodoPagamento> MetodoPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
