using Adaptador.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Core.Interface.Servicos;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Net;

namespace Application.Service
{
    public class ApplicationLogin : IApplicationLogin
    {
        private const string msgUserValidation = "USUÁRIO NÃO INFORMADO NA REQUISIÇÃO";
        private const string msgNotFound = "USUÁRIO OU SENHA INVÁLIDOS";
        private const string msgUnauthorized = "USUÁRIO DESATIVADO, SOLICITE AO ADMINISTRADOR A ATIVAÇÃO";
        private readonly IServiceUsuarios _serviceUsuarios;
        private readonly IServiceAuthAcesso _serviceAuthAcesso;
        private readonly IMapperLogin _mapperLogin;
        private readonly IGeraToken _geraToken;

        public ApplicationLogin(IServiceUsuarios serviceUsuarios, IServiceAuthAcesso serviceAuthAcesso, IGeraToken geraToken, IMapperLogin mapperLogin)
        {
            _serviceUsuarios = serviceUsuarios;
            _serviceAuthAcesso = serviceAuthAcesso;
            _geraToken = geraToken;
            _mapperLogin = mapperLogin;
        }
        public ResponseTokenDTO Login(RequestTokenDTO usuario)
        {
            try
            {
                authusuario usuarioValido = _serviceUsuarios.GetBy(usuario.username, usuario.password);
                if (usuarioValido != null)
                {
                    if (usuarioValido.situacao == 0)
                        return _mapperLogin.MapperToDTO(HttpStatusCode.Unauthorized, msgUnauthorized, null);
                    else
                    {
                        //IEnumerable<authacesso> acessos = _serviceAuthAcesso.GetAllAcessoUsuario(usuarioValido.Id);
                        var strTokenString = _geraToken.GerarTokenJWT(usuarioValido);
                        return _mapperLogin.MapperToDTO(HttpStatusCode.OK, null, strTokenString);
                    }
                }
                else
                    return _mapperLogin.MapperToDTO(HttpStatusCode.Unauthorized, msgNotFound, null);
            }
            catch (Exception Erro)
            {
                return _mapperLogin.MapperToDTO(HttpStatusCode.InternalServerError, Erro.Message, null);
            }
        }
    }
}
