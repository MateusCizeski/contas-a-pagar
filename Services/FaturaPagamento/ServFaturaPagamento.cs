using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class ServFaturaPagamento : IServFaturaPagamento
    {
        private readonly IRepFaturaPagamento _repFaturaPagamento;

        public ServFaturaPagamento(IRepFaturaPagamento repFaturaPagamento)
        {
            _repFaturaPagamento = repFaturaPagamento;
        }

        public FaturaPagamento Alterar(FaturaPagamento faturaPagamento)
        {
            _repFaturaPagamento.Alterar(faturaPagamento);

            return faturaPagamento;
        }

        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura)
        {
            var faturaPagamento = _repFaturaPagamento.ListarPorId(codigoPagamento, codigoFatura);

            return faturaPagamento;
        }

        public List<FaturaPagamento> Listar()
        {
            return _repFaturaPagamento.Listar();
        }

        public void Remover(FaturaPagamento faturaPagamento)
        {
            _repFaturaPagamento.Remover(faturaPagamento);
        }

        public FaturaPagamento Salvar(FaturaPagamento faturaPagamento)
        {
            _repFaturaPagamento.Salvar(faturaPagamento);

            return faturaPagamento;
        }
    }
}
