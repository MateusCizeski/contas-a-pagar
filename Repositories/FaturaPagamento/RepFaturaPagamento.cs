using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class RepFaturaPagamento : IRepFaturaPagamento
    {
        private readonly ConnectionContext _connectionContext;

        public RepFaturaPagamento(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        public FaturaPagamento Alterar(FaturaPagamento faturaPagamento)
        {
            _connectionContext.FaturaPagamentos.Update(faturaPagamento);
            _connectionContext.SaveChanges();

            return faturaPagamento;
        }

        public List<FaturaPagamento> Listar()
        {
           var faturasPagamentos = _connectionContext.FaturaPagamentos.ToList();

            return faturasPagamentos;
        }

        public FaturaPagamento ListarPorId(int id)
        {
            var faturaPagamento = _connectionContext.FaturaPagamentos.Where(fp => fp.Id == id).FirstOrDefault();

            if(faturaPagamento == null)
            {
                throw new Exception("Registro não encontrado");
            }

            return faturaPagamento;
        }

        public void Remover(FaturaPagamento faturaPagamento)
        {
            _connectionContext.FaturaPagamentos.Remove(faturaPagamento);
            _connectionContext.SaveChanges();
        }

        public FaturaPagamento Salvar(FaturaPagamento faturaPagamento)
        {
           _connectionContext.FaturaPagamentos.Add(faturaPagamento);
           _connectionContext.SaveChanges();

            return faturaPagamento;
        }
    }
}
