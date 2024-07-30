using api_contas_pagar.DTOs;
using api_contas_pagar.DTOs.Fornecedor;
using Microsoft.AspNetCore.Mvc;

namespace api_contas_pagar.Controllers
{
    [ApiController]
    [Route("api/v1/Fornecedor")]
    public class FornecedorController : ControllerBase
    {
        private readonly IAplicFornecedor _aplicFornecedor;

        public FornecedorController(IAplicFornecedor aplicFornecedor)
        {
            _aplicFornecedor = aplicFornecedor;
        }

        [HttpPost]
        public IActionResult SalvarFornecedor([FromBody] SalvarFornecedorDTO dto)
        {
            var fornecedor = _aplicFornecedor.Salvar(dto);

            return Ok(fornecedor);
        }

        [HttpGet]
        public IActionResult ListarFornecedores()
        {
            var fornecedores = _aplicFornecedor.ListarFornecedores();

            return Ok(fornecedores);
        }

        [HttpGet]
        [Route("ListarFornecedorPorId/{id}")]
        public IActionResult ListarFornecedorPorId([FromRoute] int id)
        {
            var fornecedor = _aplicFornecedor.ListarFornecedorPorId(id);

            return Ok(fornecedor);
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] AlterarFornecedorDTO dto)
        {
            var fornecedor = _aplicFornecedor.Alterar(dto);

            return Ok(fornecedor);
        }

        [HttpDelete]
        [Route("Fornecedor/{id}")]
        public IActionResult Remover([FromRoute] int id)
        {
            _aplicFornecedor.Remover(id);

            return Ok();
        }
    }
}
