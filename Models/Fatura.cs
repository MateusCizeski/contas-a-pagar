using System.ComponentModel;

namespace api_contas_pagar.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public int CodigoFornecedor { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data_vencimento { get; set; }
        public Boolean Pago { get; set; }
        public StatusFatura Status { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public ICollection<FaturaPagamento> FaturaPagamentos { get; set; }
    }

    public enum StatusFatura
    {
        [Description("Pendente")]
        Pendente = 1,

        [Description("Parcialmente pago")]
        ParcialmentePago = 2,

        [Description("Pago")]
        Pago = 3
    }
}
