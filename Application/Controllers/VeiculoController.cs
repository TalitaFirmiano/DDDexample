using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoController (IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]
        [Route("Cadastrar Veiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok(await _veiculoService.PostAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public IActionResult GetAsync()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }

        [HttpGet]
        [Route("AluguelDisponivel")]
        public async Task <IActionResult> GetAluguelDisponivelAsync()
        { 
            return Ok (await _veiculoService.GetAluguelDisponivelAsync());
        }

        private IActionResult Ok(object value)
        {
            throw new NotImplementedException();
        }
    }
}

