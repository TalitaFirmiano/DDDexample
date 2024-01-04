using Domain.Command;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("Cadastrar Veiculo")]
        public IActionResult PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok();
        }
        
        public IActionResult SimularAluguel()
        {
            return Ok();

        }
        public IActionResult Alugar()
        {
            return Ok();
        }
    }
}
