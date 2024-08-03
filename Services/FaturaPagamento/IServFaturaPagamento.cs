using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IServFaturaPagamento
    {
        public FaturaPagamento Salvar(FaturaPagamento fornecedor);
        public List<FaturaPagamento> Listar();
        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura);
        public FaturaPagamento Alterar(FaturaPagamento fornecedor);
        public void Remover(FaturaPagamento fornecedor);
    }
}
