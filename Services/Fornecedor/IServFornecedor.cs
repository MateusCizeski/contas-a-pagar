using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IServFornecedor
    {
        public Fornecedor SalvarFornecedor(Fornecedor fornecedor);
        public List<Fornecedor> ListarFornecedores();
        public Fornecedor ListarFornecedorPorId(int id);
        public Fornecedor Alterar(Fornecedor fornecedor);
        public void Remover(Fornecedor fornecedor);
    }
}
