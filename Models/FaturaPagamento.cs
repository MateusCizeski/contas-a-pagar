namespace api_contas_pagar.Models
{
    public class FaturaPagamento
    {
        public int CodigoFatura { get; set; }
        public int CodigoPagamento { get; set; }
        public Fatura Fatura { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
