using Dominio.Entidade;

namespace Core.Interface.Repositorio
{
    public interface IRepositoryUsuarios : IRepositoryBase<authusuario>
    {
        authusuario GetBy(string usuario, string senha);
    }
}
