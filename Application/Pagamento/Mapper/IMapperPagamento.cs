using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperPagamento
    {
        public Pagamento MapearInsercao(SalvarPagamentoDTO dto);
        public Pagamento MapearEdicao(AlterarPagamentoDTO dto, Pagamento pagamento);
    }
}
