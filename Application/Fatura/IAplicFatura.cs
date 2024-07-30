using api_contas_pagar.Models;
using api_contas_pagar.Application.Fatura.DTOs;

namespace api_contas_pagar
{
    public interface IAplicFatura
    {
        public int Salvar(SalvarFaturaDTO dto);
        public List<Fatura> ListarFaturas();
        public Fatura ListarFaturaPorId(int id);
        public Fatura Alterar(AlterarFaturaDTO dto);
        public void Remover(int id);
    }
}
