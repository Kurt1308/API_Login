using Dominio.Entidade;

namespace Core.Interface.Servicos
{
    public interface IServiceUsuarios : IServiceBase<authusuario>
    {
        authusuario GetBy(string email, string senha);
    }
}
