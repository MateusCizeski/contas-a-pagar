using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_contas_pagar
{
    public class AlterarPagamentoDTO
    {
        public int Id { get; set; }
        public DateTime Data_pagamento { get; set; }
        public Decimal Valor_pagamento { get; set; }
        public int CodigoMetodoPagamento { get; set; }
    }
}
