using api_contas_pagar.DTOs;
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
        public IActionResult SalvarFornecedor(SalvarFornecedorDTO dto)
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
    }
}
