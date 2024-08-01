using api_contas_pagar.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class AplicFornecedor : IAplicFornecedor
    {
        private readonly IServFornecedor _servFornecedor;
        private readonly IMapperFornecedor _mapperFornecedor;

        public AplicFornecedor(IServFornecedor servFornecedor, IMapperFornecedor mapperFornecedor)
        {
            _servFornecedor = servFornecedor;
            _mapperFornecedor = mapperFornecedor;
        }

        public List<Fornecedor> ListarFornecedores()
        {
            var fornecedores = _servFornecedor.ListarFornecedores();

            return fornecedores;
        }

        public int Salvar(SalvarFornecedorDTO dto)
        {
            var mapperFornec = _mapperFornecedor.MapearInsercao(dto);
            var fornecedor = _servFornecedor.SalvarFornecedor(mapperFornec);

            return fornecedor.Id;
        }

        public Fornecedor ListarFornecedorPorId(int id)
        {
            var fornecedor = _servFornecedor.ListarFornecedorPorId(id);

            return fornecedor;
        }

        public Fornecedor Alterar(AlterarFornecedorDTO dto)
        {
            var fornecedor = _servFornecedor.ListarFornecedorPorId(dto.Id);
            var mapper = _mapperFornecedor.MapearEdicao(dto, fornecedor);

            return _servFornecedor.Alterar(mapper);
        }

        public void Remover(int id)
        {
            var fornecedor = _servFornecedor.ListarFornecedorPorId(id);
            _servFornecedor.Remover(fornecedor);
        }
    }
}
