using api_contas_pagar.Models;
using api_contas_pagar.Repositories;

namespace api_contas_pagar.Services
{
    public class ServMetodoPagamento : IServMetodoPagamento
    {
        private readonly IRepMetodoPagamento _repMetodoPagamento;

        public ServMetodoPagamento(IRepMetodoPagamento repMetodoPagamento)
        {
            _repMetodoPagamento = repMetodoPagamento;
        }

        public MetodoPagamento Alterar(MetodoPagamento pagamento)
        {
            _repMetodoPagamento.Alterar(pagamento);

            return pagamento;
        }

        public MetodoPagamento ListarMetodoPagPorId(int id)
        {
            var metodoPagamento = _repMetodoPagamento.ListarMetodoPagPorId(id);

            return metodoPagamento;
        }

        public List<MetodoPagamento> ListarMetodosPagamentos()
        {
            var metodosPagamentos = _repMetodoPagamento.ListarMetodosPagamentos();

            return metodosPagamentos;
        }

        public void Remover(MetodoPagamento pagamento)
        {
            _repMetodoPagamento.Remover(pagamento);
        }

        public MetodoPagamento Salvar(MetodoPagamento pagamento)
        {
            _repMetodoPagamento.Salvar(pagamento);

            return pagamento;
        }
    }
}
