namespace api_contas_pagar
{
    public class AlterarFaturaPagamentoDTO
    {
        public int Id { get; set; }
        public int CodigoFatura { get; set; }
        public int CodigoPagamento { get; set; }
        public decimal ValorPago { get; set; }
    }
}
