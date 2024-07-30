using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IServFatura
    {
        public Fatura SalvarFatura(Fatura fornecedor);
        public List<Fatura> ListarFaturas();
        public Fatura ListarFaturaPorId(int id);
        public Fatura Alterar(Fatura fornecedor);
        public void Remover(Fatura fornecedor);
    }
}
