using Dominio.Entidade;
using System.Collections.Generic;

namespace Core.Interface.Repositorio
{
    public interface IRepositoryUsuarios : IRepositoryBase<authusuario>
    {
        authusuario GetBy(string usuario, string senha);
        authusuario GetBy(string usuario);
        authusuario GetByCpf(string cpf);
        authusuario GetById(long idUsuario);
        IEnumerable<authusuario> GetAll();
        authusuario UpdateUsuario(authusuario usuario);
        IEnumerable<authusuario> GetByFiltro(string usuario, string email, int? situacao, int? administrador, long? grupo);
        authusuario GetByEmail(string email);
        authusuario GetByEmailPassword(string email, string password);
    }
}
