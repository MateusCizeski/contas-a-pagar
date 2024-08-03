using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicFaturaPagamento
    {
        public int Salvar(SalvarFaturaPagamentoDTO dto);
        public List<FaturaPagamento> Listar();
        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura);
        public FaturaPagamento Alterar(AlterarFaturaPagamentoDTO dto);
        public void Remover(int codigoPagamento, int codigoFatura);
    }
}
