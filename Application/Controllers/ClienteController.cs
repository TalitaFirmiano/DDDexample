using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        [HttpPost]
        [Route("Cadastrar Cliente")]
        public async Task<IActionResult> PostAsync([FromBody] ClienteCommand command)
        {
            return Ok(await _clienteService.PostAsync(command));
        }
    }
}