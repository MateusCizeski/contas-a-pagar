using api_contas_pagar.Application.Fatura.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IMapperFatura
    {
        public Fatura MapearInsercao(SalvarFaturaDTO dto);
        public void MapearEdicao(AlterarFaturaDTO dto, Fatura fatura);
    }
}
