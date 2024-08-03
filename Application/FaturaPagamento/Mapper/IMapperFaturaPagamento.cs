using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperFaturaPagamento
    {
        public FaturaPagamento MapearInsercao(SalvarFaturaPagamentoDTO dto);
        public void MapearEdicao(AlterarFaturaPagamentoDTO dto, FaturaPagamento faturaPagamento);
    }
}
