using Microsoft.AspNetCore.Mvc;

namespace api_contas_pagar.Controllers
{
    [ApiController]
    [Route("api/v1/Pagamento")]
    public class PagamentoController : ControllerBase
    {
        private readonly IAplicPagamento _aplicPagamento;

        public PagamentoController(IAplicPagamento aplicPagamento)
        {
            _aplicPagamento = aplicPagamento;
        }

        [HttpPost]
        public IActionResult Salvar(SalvarPagamentoDTO dto)
        {
            var pagamento = _aplicPagamento.Salvar(dto);

            return Ok(pagamento);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var pagamentos = _aplicPagamento.ListarPagamentos();

            return Ok(pagamentos);
        }

        [HttpGet]
        [Route("ListarPagPorId/{id}")]
        public IActionResult ListarPagPorId([FromRoute] int id)
        {
            var pagamento = _aplicPagamento.ListarPagamentoPorId(id);

            return Ok(pagamento);
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] AlterarPagamentoDTO dto)
        {
            var pagamento = _aplicPagamento.Alterar(dto);

            return Ok(pagamento);
        }

        [HttpDelete]
        [Route("RemoverPag/{id}")]
        public IActionResult Remover([FromRoute] int id)
        {
            _aplicPagamento.Remover(id);

            return Ok();
        }
    }
}
