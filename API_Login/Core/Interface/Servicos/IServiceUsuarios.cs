using Dominio.Entidade;
using System.Collections.Generic;

namespace Core.Interface.Servicos
{
    public interface IServiceUsuarios : IServiceBase<authusuario>
    {
        authusuario GetBy(string email, string senha);
        authusuario GetBy(string usuario);
        authusuario GetByCpf(string cpf);
        List<authusuario> GetAll();
        List<authusuario> GetByFiltro(string usuario, string email, int? situacao, int? administrador, long? grupo);
        authusuario GetByEmail(string email);
        authusuario UpdateUsuario(authusuario usuario);
        authusuario GetById(long idUsuario);
        authusuario GetByEmailPassword(string email, string password);
    }
}
