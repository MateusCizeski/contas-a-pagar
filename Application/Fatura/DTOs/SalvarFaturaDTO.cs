using api_contas_pagar.Models;

namespace api_contas_pagar.Application.Fatura.DTOs
{
    public class SalvarFaturaDTO
    {
        public int CodigoFornecedor { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data_vencimento { get; set; }
        public Boolean Pago { get; set; }
        public StatusFatura Status { get; set; }
    }
}
