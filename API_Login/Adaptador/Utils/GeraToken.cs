using System;
using System.Text;
using System.Security.Claims;
using System.Collections.Generic;
using System.IO;
using Adaptador.Interfaces;
using Dominio.Entidade;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Adapter.Utils
{
    public class GeraToken : IGeraToken
    {
        public string GerarTokenJWT(authusuario usuario)
        {
            var Configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .Build();

            var dtimeExpiry = DateTime.Now.AddHours(2);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims_token = new List<Claim>();

            claims_token.Add(new Claim("id", usuario.Id.ToString()));
            claims_token.Add(new Claim("nome", usuario.usuario));
            claims_token.Add(new Claim("email", usuario.email));
            claims_token.Add(new Claim("situacao", usuario.situacao.ToString()));
            claims_token.Add(new Claim("administrador", usuario.administrador.ToString()));
            claims_token.Add(new Claim("grupo", usuario.grupo.ToString()));
            claims_token.Add(new Claim("cpf", usuario.Cpf));

            var token = new JwtSecurityToken(claims: claims_token, issuer: Configuration["Jwt:Issuer"], audience: Configuration["Jwt:Audience"], expires: dtimeExpiry, signingCredentials: credentials);
            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return "Bearer " + stringToken;
        }
    }
}
