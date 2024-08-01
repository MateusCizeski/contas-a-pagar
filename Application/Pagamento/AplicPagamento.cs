using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class AplicPagamento : IAplicPagamento
    {
        private readonly IServPagamento _servPagamento;
        private readonly IMapperPagamento _mapperPagamento;

        public AplicPagamento(IServPagamento servPagamento, IMapperPagamento mapperPagamento)
        {
            _servPagamento = servPagamento;
            _mapperPagamento = mapperPagamento;
        }

        public Pagamento Alterar(AlterarPagamentoDTO dto)
        {
            var pagamento = _servPagamento.ListarPagamentoPorId(dto.Id);
            var mapperPag = _mapperPagamento.MapearEdicao(dto, pagamento);

            if(mapperPag == null)
            {
                throw new Exception("Pagamento não encontrado.");
            }

            return _servPagamento.Alterar(mapperPag);
        }

        public Pagamento ListarPagamentoPorId(int id)
        {
            var pagamento = _servPagamento.ListarPagamentoPorId(id);

            return pagamento;
        }

        public List<Pagamento> ListarPagamentos()
        {
            var pagamentos = _servPagamento.ListarPagamentos();

            return pagamentos;
        }

        public void Remover(int id)
        {
            var pagamento = _servPagamento.ListarPagamentoPorId(id);

            _servPagamento.Remover(pagamento);
        }

        public int Salvar(SalvarPagamentoDTO dto)
        {
            var mapperPagamento = _mapperPagamento.MapearInsercao(dto);
            var pagamento = _servPagamento.Salvar(mapperPagamento);

            return pagamento.Id;
        }
    }
}
