using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicPagamento
    {
        public int Salvar(SalvarPagamentoDTO dto);
        public List<Pagamento> ListarPagamentos();
        public Pagamento ListarPagamentoPorId(int id);
        public Pagamento Alterar(AlterarPagamentoDTO dto);
        public void Remover(int id);
    }
}
