using api_contas_pagar.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
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

        public void MapearEdicao(AlterarFornecedorDTO dto, Fornecedor fornecedor)
        {
            fornecedor.Nome = dto.Nome;
            fornecedor.Endereco = dto.Endereco;
            fornecedor.Telefone = dto.Telefone;
        }
    }
}
