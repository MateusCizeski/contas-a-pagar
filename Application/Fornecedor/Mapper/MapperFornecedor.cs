using api_contas_pagar.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class MapperFornecedor : IMapperFornecedor
    {
        public Fornecedor MapearInsercao(SalvarFornecedorDTO dto)
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Nome = dto.Nome,
                Endereco = dto.Endereco,
                Telefone = dto.Telefone,
            };

            return fornecedor;
        }
    }
}
