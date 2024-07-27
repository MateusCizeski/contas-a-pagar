using api_contas_pagar.DTOs.Fatura;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IRepFatura
    {
        public void SalvarFatura(SalvarFaturaDTO dto);
        public Fatura AlterarFatura(AlterarFaturaDTO dto);
        public List<Fatura> ListarFaturas();
        public Fatura ListarFaturaPorId(int id);
        public void RemoverFatura(int id);
    }
}
