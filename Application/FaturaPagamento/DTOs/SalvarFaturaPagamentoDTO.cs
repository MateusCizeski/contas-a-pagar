namespace api_contas_pagar
{
    public class SalvarFaturaPagamentoDTO
    {
        public int CodigoFatura { get; set; }
        public int CodigoPagamento { get; set; }
        public decimal ValorPago { get; set; }
    }
}
