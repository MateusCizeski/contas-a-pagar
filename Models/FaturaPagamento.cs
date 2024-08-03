﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("fatura_pagamentos", Schema = "contas_pagar")]
    public class FaturaPagamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("fatura_id")]
        public int CodigoFatura { get; set; }

        [Column("pagamento_id")]
        public int CodigoPagamento { get; set; }
        public Fatura Fatura { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
