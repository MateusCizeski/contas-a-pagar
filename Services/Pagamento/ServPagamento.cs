using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class ServPagamento : IServPagamento
    {
        private readonly IRepPagamento _repPagamento;

        public ServPagamento(IRepPagamento repPagamento)
        {
            _repPagamento = repPagamento;
        }

        public Pagamento Alterar(Pagamento pagamento)
        {
            var pagamentoAlterado = _repPagamento.Alterar(pagamento);
            
            return pagamentoAlterado;
        }

        public Pagamento ListarPagamentoPorId(int id)
        {
            var pagamento = _repPagamento.ListarPagamentoPorId(id);

            return pagamento;
        }

        public List<Pagamento> ListarPagamentos()
        {
            return _repPagamento.ListarPagamentos();
        }

        public void Remover(Pagamento pagamento)
        {
            _repPagamento.Remover(pagamento);
        }

        public Pagamento Salvar(Pagamento pagamento)
        {
            var novoPagamento = _repPagamento.Salvar(pagamento);

            return novoPagamento;
        }
    }
}
