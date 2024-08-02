using api_contas_pagar.Application.MetodoPagamento.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public interface IAplicMetodoPagamento
    {
        public int Salvar(string nome);
        public List<MetodoPagamento> ListarPagamentos();
        public MetodoPagamento ListarPagamentoPorId(int id);
        public MetodoPagamento Alterar(AlterarMetodoPagamentoDTO dto);
        public void Remover(int id);
    }
}
