using System.Net;
using Adaptador.Interfaces;
using ApplicationDTO.ResponseDTO;


namespace Adapter.Map
{
    public class MapperLogin : IMapperLogin
    {
        public ResponseTokenDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, string token)
        {
            return new ResponseTokenDTO()
            {
                codRetorno = codRetorno,
                mensagem = mensagem,
                token = token
            };
        }
    }
}
