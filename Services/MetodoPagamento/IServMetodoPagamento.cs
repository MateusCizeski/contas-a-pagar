using api_contas_pagar.Models;

namespace api_contas_pagar.Services
{
    public interface IServMetodoPagamento
    {
        public MetodoPagamento Salvar(MetodoPagamento pagamento);
        public List<MetodoPagamento> ListarMetodosPagamentos();
        public MetodoPagamento ListarMetodoPagPorId(int id);
        public MetodoPagamento Alterar(MetodoPagamento pagamento);
        public void Remover(MetodoPagamento pagamento);
    }
}
