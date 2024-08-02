using api_contas_pagar.Models;

namespace api_contas_pagar.Repositories
{
    public class RepMetodoPagamento : IRepMetodoPagamento
    {
        private readonly ConnectionContext _connectionContext;

        public RepMetodoPagamento(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public MetodoPagamento Alterar(MetodoPagamento metodoPagamento)
        {
            _connectionContext.MetodosPagamento.Update(metodoPagamento);
            _connectionContext.SaveChanges();

            return metodoPagamento;
        }

        public MetodoPagamento ListarMetodoPagPorId(int id)
        {
            var metodoPagamento = _connectionContext.MetodosPagamento.Where(mp => mp.Id == id).FirstOrDefault();

            return metodoPagamento;
        }

        public List<MetodoPagamento> ListarMetodosPagamentos()
        {
            var metodosPagamentos = _connectionContext.MetodosPagamento.ToList();

            return metodosPagamentos;
        }

        public void Remover(MetodoPagamento metodoPagamento)
        {
            _connectionContext.MetodosPagamento.Remove(metodoPagamento);
            _connectionContext.SaveChanges();
        }

        public MetodoPagamento Salvar(MetodoPagamento metodoPagamento)
        {
            _connectionContext.MetodosPagamento.Add(metodoPagamento);
            _connectionContext.SaveChanges();

            return metodoPagamento;
        }
    }
}
