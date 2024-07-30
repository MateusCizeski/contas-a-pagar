using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("metodo_pagamento", Schema = "contas_pagar")]
    public class MetodoPagamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
    }
}
