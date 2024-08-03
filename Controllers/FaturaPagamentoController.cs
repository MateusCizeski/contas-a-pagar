using Microsoft.AspNetCore.Mvc;

namespace api_contas_pagar.Controllers
{
    [ApiController]
    [Route("api/v1/FaturaPagamento")]
    public class FaturaPagamentoController : ControllerBase
    {
        private readonly IAplicFaturaPagamento _aplicFaturaPagamento;

        public FaturaPagamentoController(IAplicFaturaPagamento aplicFaturaPagamento)
        {
            _aplicFaturaPagamento = aplicFaturaPagamento;
        }

        [HttpPost]
        public IActionResult Salvar([FromBody] SalvarFaturaPagamentoDTO dto)
        {
            var faturaPagamento = _aplicFaturaPagamento.Salvar(dto);

            return Ok(faturaPagamento);
        }

        [HttpPut]
        public IActionResult Altrar([FromBody] AlterarFaturaPagamentoDTO dto)
        {
            var faturaPagamento = _aplicFaturaPagamento.Alterar(dto);

            return Ok(faturaPagamento);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var faturasPagamentos = _aplicFaturaPagamento.Listar();

            return Ok(faturasPagamentos);
        }

        [HttpGet]
        [Route("ListarFaturasPag/{codigoPagamento}/{codigoFatura}")]
        public IActionResult ListarPorId([FromRoute] int codigoPagamento, [FromRoute]int codigoFatura)
        {
            var faturaPagamento = _aplicFaturaPagamento.ListarPorId(codigoPagamento, codigoFatura);

            return Ok(faturaPagamento);
        }

        [HttpDelete]
        [Route("RemoverFaturasPag/{codigoPagamento}/{codigoFatura}")]
        public IActionResult Remover([FromRoute] int codigoPagamento, [FromRoute] int codigoFatura)
        {
            _aplicFaturaPagamento.Remover(codigoPagamento, codigoFatura);

            return Ok();
        }
    }
}
