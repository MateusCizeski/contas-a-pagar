using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IRepPagamento
    {
        public Pagamento Salvar(Pagamento pagamento);
        public Pagamento Alterar(Pagamento pagamento);
        public List<Pagamento> ListarPagamentos();
        public Pagamento ListarPagamentoPorId(int id);
        public void Remover(Pagamento pagamento);
    }
}
