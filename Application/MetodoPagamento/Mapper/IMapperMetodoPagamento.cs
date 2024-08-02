using api_contas_pagar.Application.MetodoPagamento.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperMetodoPagamento
    {
        public MetodoPagamento MapearInsercao(string nome);
        public MetodoPagamento MapearEdicao(AlterarMetodoPagamentoDTO dto, MetodoPagamento pagamento);
    }
}
