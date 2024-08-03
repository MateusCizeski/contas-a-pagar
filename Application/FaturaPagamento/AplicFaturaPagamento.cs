using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class AplicFaturaPagamento : IAplicFaturaPagamento
    {
        private readonly IServFaturaPagamento _servFaturaPagamento;
        private readonly IMapperFaturaPagamento _mapper;

        public AplicFaturaPagamento(IServFaturaPagamento servFaturaPagamento, IMapperFaturaPagamento mapper)
        {
            _servFaturaPagamento = servFaturaPagamento;
            _mapper = mapper;
        }

        public FaturaPagamento Alterar(AlterarFaturaPagamentoDTO dto)
        {
            var faturaPagamento = _servFaturaPagamento.ListarPorId(dto.CodigoPagamento, dto.CodigoFatura);
            _mapper.MapearEdicao(dto, faturaPagamento);

            return _servFaturaPagamento.Alterar(faturaPagamento);
        }

        public List<FaturaPagamento> Listar()
        {
            var faturaPagamentos = _servFaturaPagamento.Listar();

            return faturaPagamentos;
        }

        public FaturaPagamento ListarPorId(int codigoPagamento, int codigoFatura)
        {
            var faturaPagamento = _servFaturaPagamento.ListarPorId(codigoPagamento, codigoFatura);

            return faturaPagamento;
        }

        public void Remover(int codigoPagamento, int codigoFatura)
        {
            var faturaPagamento = _servFaturaPagamento.ListarPorId(codigoPagamento, codigoFatura);

            _servFaturaPagamento.Remover(faturaPagamento);
        }

        public int Salvar(SalvarFaturaPagamentoDTO dto)
        {
            var faturaPagamento = _mapper.MapearInsercao(dto);
            _servFaturaPagamento.Salvar(faturaPagamento);

            return faturaPagamento.CodigoPagamento;
        }
    }
}
