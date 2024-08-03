using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("fatura_pagamentos", Schema = "contas_pagar")]
    public class FaturaPagamento
    {
        [Key]
        [Column("fatura_id")]
        public int CodigoFatura { get; set; }

        [Key]
        [Column("pagamento_id")]
        public int CodigoPagamento { get; set; }

        [Column("valor_pago")]
        public decimal ValorPago { get; set; }
        public Fatura Fatura { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
