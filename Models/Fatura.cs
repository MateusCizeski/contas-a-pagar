using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("faturas", Schema = "contas_pagar")]
    public class Fatura
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("fornecedor_id")]
        public int CodigoFornecedor { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("datavencimento")]
        public DateTime Data_vencimento { get; set; }

        [Column("pago")]
        public Boolean Pago { get; set; }

        [Column("status")]
        public StatusFatura Status { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public ICollection<FaturaPagamento> FaturaPagamentos { get; set; }
    }

    public enum StatusFatura
    {
        [Description("Pendente")]
        Pendente = 1,

        [Description("Parcialmente pago")]
        ParcialmentePago = 2,

        [Description("Pago")]
        Pago = 3
    }
}
