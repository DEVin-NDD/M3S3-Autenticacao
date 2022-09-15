using autenticacao.Dtos;
using autenticacao.Repositories;
using autenticacao.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace autenticacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] UserDto dto){

            var user = UserRepository.VerificarUsuarioESenha(dto);

            if(user == null) return Unauthorized();

            var token = TokenService.GenerateToken(user);

            return Ok(token);
        }

    }
}