using ApplicationDTO.ResponseDTO;
using System.Net;

namespace Adaptador.Interfaces
{
    public interface IMapperLogin
    {
        ResponseTokenDTO MapperToDTO(HttpStatusCode codRetorno, string mensagem, string token);
    }
}