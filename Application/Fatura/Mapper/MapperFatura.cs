using api_contas_pagar.Application.Fatura.DTOs;
using api_contas_pagar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contas_pagar
{
    public class MapperFatura : IMapperFatura
    {
        public Fatura MapearEdicao(AlterarFaturaDTO dto, Fatura fatura)
        {
            fatura.CodigoFornecedor = dto.CodigoFornecedor;
            fatura.Valor = dto.Valor;
            fatura.Data_vencimento = dto.Data_vencimento;
            fatura.Pago = dto.Pago;
            fatura.Status = dto.Status;

            return fatura;
    }

        public Fatura MapearInsercao(SalvarFaturaDTO dto)
        {
            Fatura fatura = new Fatura()
            {
                CodigoFornecedor = dto.CodigoFornecedor,
                Valor = dto.Valor,
                Data_vencimento = DateTime.UtcNow,
                Pago = false,
                Status = StatusFatura.Pendente
            };
            
            return fatura;
        }
    }
}
