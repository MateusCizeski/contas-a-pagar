using api_contas_pagar.Application.MetodoPagamento.DTOs;
using api_contas_pagar.Models;
using api_contas_pagar.Services;

namespace api_contas_pagar
{
    public class AplicMetodoPagamento : IAplicMetodoPagamento
    {
        private readonly IServMetodoPagamento _servMetodoPagamento;
        private readonly IMapperMetodoPagamento _mapper;

        public AplicMetodoPagamento(IServMetodoPagamento servMetodoPagamento, IMapperMetodoPagamento mapper)
        {
            _servMetodoPagamento = servMetodoPagamento;
            _mapper = mapper;
        }

        public MetodoPagamento Alterar(AlterarMetodoPagamentoDTO dto)
        {
            var metodoPag = _servMetodoPagamento.ListarMetodoPagPorId(dto.Id);
            _mapper.MapearEdicao(dto, metodoPag);

            return _servMetodoPagamento.Alterar(metodoPag);
        }

        public MetodoPagamento ListarPagamentoPorId(int id)
        {
            var metodoPagamento = _servMetodoPagamento.ListarMetodoPagPorId(id);

            return metodoPagamento;
        }

        public List<MetodoPagamento> ListarPagamentos()
        {
            return _servMetodoPagamento.ListarMetodosPagamentos();
        }

        public void Remover(int id)
        {
            var metodoPagamento = _servMetodoPagamento.ListarMetodoPagPorId(id);

            _servMetodoPagamento.Remover(metodoPagamento);
        }

        public int Salvar(string nome)
        {
            var metodoPagamento = _mapper.MapearInsercao(nome);
            _servMetodoPagamento.Salvar(metodoPagamento);

            return metodoPagamento.Id;
        }
    }
}
