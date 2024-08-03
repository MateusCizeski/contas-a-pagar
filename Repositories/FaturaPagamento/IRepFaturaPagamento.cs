using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IRepFaturaPagamento
    {
        public FaturaPagamento Salvar(FaturaPagamento faturaPagamento);
        public FaturaPagamento Alterar(FaturaPagamento faturaPagamento);
        public List<FaturaPagamento> Listar();
        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura);
        public void Remover(FaturaPagamento faturaPagamento);
    }
}
