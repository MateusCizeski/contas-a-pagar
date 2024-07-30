using api_contas_pagar.Application.Fatura;
using api_contas_pagar.Application.Fatura.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
using Microsoft.AspNetCore.Mvc;

namespace api_contas_pagar.Controllers
{
    [ApiController]
    [Route("api/v1/Fatura")]
    public class FaturaController : ControllerBase
    {
        private readonly IAplicFatura _aplicFatura;

        public FaturaController(IAplicFatura aplicFatura)
        {
            _aplicFatura = aplicFatura;
        }

        [HttpPost]
        public IActionResult SalvarFatura(SalvarFaturaDTO dto)
        {
            var fatura = _aplicFatura.Salvar(dto);

            return Ok(fatura);
        }

        [HttpGet]
        public IActionResult ListarFatura()
        {
            var faturas = _aplicFatura.ListarFaturas();

            return Ok(faturas);
        }

        [HttpGet]
        [Route("ListarFaturaPorId/{id}")]
        public IActionResult ListarFaturaPorId([FromRoute] int id)
        {
            var fatura = _aplicFatura.ListarFaturaPorId(id);

            return Ok(fatura);
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] AlterarFaturaDTO dto)
        {
            var fatura = _aplicFatura.Alterar(dto);

            return Ok(fatura);
        }

        [HttpDelete]
        [Route("Fatura/{id}")]
        public IActionResult Remover([FromRoute] int id)
        {
            _aplicFatura.Remover(id);

            return Ok();
        }
    }
}
