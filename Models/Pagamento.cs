using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar.Models
{
    [Table("pagamentos", Schema = "contas_pagar")]
    public class Pagamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("data_pagamento")]
        public DateTime Data_pagamento { get; set; }

        [Column("valor_pagamento")]
        public Decimal Valor_pagamento { get; set; }

        [Column("codigo_metodo_pagamento")]
        public int CodigoMetodoPagamento { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
        public ICollection<FaturaPagamento> FaturaPagamentos { get; set; }
    }
}
