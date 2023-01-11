using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Login.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IApplicationLogin _applicationLogin;
        public LoginController(IApplicationLogin applicationLogin)
        {
            _applicationLogin = applicationLogin;
        }

        /// <summary>
        /// Endpoint para buscar o token de login
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Retorna uma mensagem de confirmação</returns>
        /// <response code="200">Atualização realizada com sucesso</response>
        /// <response code="400">Campos obrigatórios não informados</response>
        /// <response code="401">Acesso não autenticado</response>
        /// <response code="403">Acesso não autorizado</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(ResponseTokenDTO), 200)]
        [ProducesResponseType(typeof(ResponseTokenDTO), 401)]
        [ProducesResponseType(typeof(ResponseTokenDTO), 500)]
        [HttpPost]
        [AllowAnonymous]
        public ResponseTokenDTO GetTokenForLogin(RequestTokenDTO request)
        {
            var retorno = _applicationLogin.Login(request);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}