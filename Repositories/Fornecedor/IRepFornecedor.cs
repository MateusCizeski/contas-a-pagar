using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IRepFornecedor
    {
        public Fornecedor Salvar(Fornecedor fornecedor);
        public Fornecedor Alterar(AlterarFornecedorDTO dto);
        public List<Fornecedor> ListarFornecedores();
        public Fornecedor ListarFornecedorPorId(int id);
        public void RemoverFornecedor(int id);
    }
}
