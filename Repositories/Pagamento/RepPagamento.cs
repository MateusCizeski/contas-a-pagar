using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class RepPagamento : IRepPagamento
    {
        private readonly ConnectionContext _connectionContext;

        public RepPagamento(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public Pagamento Alterar(Pagamento pagamento)
        {
            _connectionContext.Pagamentos.Update(pagamento);
            _connectionContext.SaveChanges();

            return pagamento;
        }

        public Pagamento ListarPagamentoPorId(int id)
        {
            var pagamento = _connectionContext.Pagamentos.Where(p => p.Id == id).FirstOrDefault();

            if (pagamento == null) 
            {
                throw new Exception("Pagamento não encontrado");
            }

            return pagamento;
        }

        public List<Pagamento> ListarPagamentos()
        {
            var pagamentos = _connectionContext.Pagamentos.ToList();

            return pagamentos;
        }

        public void Remover(Pagamento pagamento)
        {
            _connectionContext.Pagamentos.Remove(pagamento);
            _connectionContext.SaveChanges();
        }

        public Pagamento Salvar(Pagamento pagamento)
        {
            _connectionContext.Pagamentos.Add(pagamento);
            _connectionContext.SaveChanges();

            return pagamento;
        }
    }
}
