namespace api_contas_pagar.DTOs.Fatura
{
    public class SalvarFaturaDTO
    {
        public int CodigoFornecedor { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data_vencimento { get; set; }
        public Boolean Pago { get; set; }
    }
}
