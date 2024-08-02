using api_contas_pagar.Models;

namespace api_contas_pagar.Repositories
{
    public interface IRepMetodoPagamento
    {
        public MetodoPagamento Salvar(MetodoPagamento metodoPagamento);
        public MetodoPagamento Alterar(MetodoPagamento metodoPagamento);
        public List<MetodoPagamento> ListarMetodosPagamentos();
        public MetodoPagamento ListarMetodoPagPorId(int id);
        public void Remover(MetodoPagamento metodoPagamento);
    }
}
