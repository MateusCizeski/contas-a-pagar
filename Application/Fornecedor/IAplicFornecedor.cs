using api_contas_pagar.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicFornecedor
    {
        public int Salvar(SalvarFornecedorDTO dto);
        public List<Fornecedor> ListarFornecedores();
    }
}
