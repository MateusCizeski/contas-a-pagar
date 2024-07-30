using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperPagamento
    {
        public Pagamento MapearInsercao(SalvarPagamentoDTO dto);
        public void MapearEdicao(AlterarPagamentoDTO dto, Pagamento pagamento);
    }
}
