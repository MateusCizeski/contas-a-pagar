using api_contas_pagar.Models;
using api_contas_pagar.Services.Pagamento;

namespace api_contas_pagar
{
    public class AplicPagamento : IAplicPagamento
    {
        private readonly IServPagamento _servPagamento;

        public AplicPagamento(IServPagamento servPagamento)
        {
            _servPagamento = servPagamento;
        }

        public Fatura Alterar(AlterarPagamentoDTO dto)
        {
            throw new NotImplementedException();
        }

        public Fatura ListarPagamentoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pagamento> ListarPagamentos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public int Salvar(SalvarPagamentoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
