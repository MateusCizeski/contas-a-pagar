using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IRepFatura
    {
        public Fatura SalvarFatura(Fatura fatura);
        public Fatura AlterarFatura(Fatura fatura);
        public List<Fatura> ListarFaturas();
        public Fatura ListarFaturaPorId(int id);
        public void RemoverFatura(Fatura fatura);
    }
}
