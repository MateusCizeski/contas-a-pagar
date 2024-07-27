namespace api_contas_pagar.Models
{
    public class MetodoPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
    }
}
