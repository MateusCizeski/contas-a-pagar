using api_contas_pagar.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class MapperFaturaPagamento : IMapperFaturaPagamento
    {
        public void MapearEdicao(AlterarFaturaPagamentoDTO dto, FaturaPagamento faturaPagamento)
        {
           faturaPagamento.CodigoPagamento = dto.CodigoPagamento;
           faturaPagamento.CodigoFatura = dto.CodigoFatura;
           faturaPagamento.ValorPago = dto.ValorPago;
        }

        public FaturaPagamento MapearInsercao(SalvarFaturaPagamentoDTO dto)
        {
            FaturaPagamento faturaPagamento = new FaturaPagamento()
            {
                CodigoFatura = dto.CodigoFatura,
                CodigoPagamento = dto.CodigoPagamento,
                ValorPago = dto.ValorPago
            };

            return faturaPagamento;
        }
    }
}
