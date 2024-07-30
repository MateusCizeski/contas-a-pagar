using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicPagamento
    {
        public int Salvar(SalvarPagamentoDTO dto);
        public List<Pagamento> ListarPagamentos();
        public Fatura ListarPagamentoPorId(int id);
        public Fatura Alterar(AlterarPagamentoDTO dto);
        public void Remover(int id);
    }
}
