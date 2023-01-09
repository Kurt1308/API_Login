using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;

namespace Application.Interface
{
    public interface IApplicationLogin
    {
        ResponseTokenDTO Login(RequestTokenDTO usuario);
    }
}