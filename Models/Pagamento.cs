namespace api_contas_pagar.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data_pagamento { get; set; }
        public Decimal Valor_pagamento { get; set; }
        public int CodigoMetodoPagamento { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
        public ICollection<FaturaPagamento> FaturaPagamentos { get; set; }
    }
}
