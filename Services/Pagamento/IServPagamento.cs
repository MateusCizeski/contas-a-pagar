using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IServPagamento
    {
        public Pagamento Salvar(Pagamento pagamento);
        public List<Pagamento> ListarPagamentos();
        public Pagamento ListarPagamentoPorId(int id);
        public Pagamento Alterar(Pagamento pagamento);
        public void Remover(Pagamento pagamento);
    }
}
