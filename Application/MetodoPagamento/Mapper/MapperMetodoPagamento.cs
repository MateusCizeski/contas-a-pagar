using api_contas_pagar.Application.MetodoPagamento.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class MapperMetodoPagamento : IMapperMetodoPagamento
    {
        public MetodoPagamento MapearEdicao(AlterarMetodoPagamentoDTO dto, MetodoPagamento pagamento)
        {
            pagamento.Nome = dto.Nome;

            return pagamento;
        }

        public MetodoPagamento MapearInsercao(string nome)
        {
            var metodoPagamento = new MetodoPagamento()
            {
                Nome = nome
            };

            return metodoPagamento;
        }
    }
}
