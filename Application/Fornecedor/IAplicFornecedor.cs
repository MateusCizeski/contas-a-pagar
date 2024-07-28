using api_contas_pagar.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicFornecedor
    {
        public int Salvar(SalvarFornecedorDTO dto);
        public List<Fornecedor> ListarFornecedores();
        public Fornecedor ListarFornecedorPorId(int id);
        public Fornecedor Alterar(AlterarFornecedorDTO dto);
        public void Remover(int id);
    }
}
