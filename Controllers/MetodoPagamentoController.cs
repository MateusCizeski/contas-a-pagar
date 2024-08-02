using api_contas_pagar.Application.MetodoPagamento.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api_contas_pagar.Controllers
{
    [ApiController]
    [Route("api/v1/MetodoPagamento")]
    public class MetodoPagamentoController : ControllerBase
    {
        private readonly IAplicMetodoPagamento _aplicMetodoPagamento;

        public MetodoPagamentoController(IAplicMetodoPagamento aplicMetodoPagamento)
        {
            _aplicMetodoPagamento = aplicMetodoPagamento;
        }

        [HttpPost]
        public IActionResult Salvar([FromBody] string nome)
        {
            var metodoPagamento = _aplicMetodoPagamento.Salvar(nome);

            return Ok(metodoPagamento);
        }

        [HttpPut]
        public IActionResult Alterar(AlterarMetodoPagamentoDTO dto)
        {
            var metodoPagamento = _aplicMetodoPagamento.Alterar(dto);

            return Ok(metodoPagamento);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var metodosPagamentos = _aplicMetodoPagamento.ListarPagamentos();

            return Ok(metodosPagamentos);
        }

        [HttpGet]
        [Route("ListarMetodoPagId/{id}")]
        public IActionResult ListarMetodoPagId([FromRoute] int id)
        {
            var metodoPagamento = _aplicMetodoPagamento.ListarPagamentoPorId(id);

            return Ok(metodoPagamento);
        }

        [HttpDelete]
        [Route("RemoverMetodoPag/{id}")]
        public IActionResult Remover([FromRoute] int id)
        {
            _aplicMetodoPagamento.Remover(id);

            return Ok();
        }
    }
}
