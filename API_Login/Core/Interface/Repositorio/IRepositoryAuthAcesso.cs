using Dominio.Entidade;
using System.Collections.Generic;

namespace Core.Interface.Repositorio
{
    public interface IRepositoryAuthAcesso : IRepositoryBase<authacesso>
    {
        IEnumerable<authacesso> GetAll();
        authacesso GetById(long idAuthAcesso);
        authacesso GetBy(string acessoPermissao);
        IEnumerable<authacesso> GetByFiltro(string acessoPermissao, string descricaoPermissao, int? situacao);
        authacesso UpdateAuthAcesso(authacesso authAcesso);
        IEnumerable<authacesso> GetAllAcessoUsuario(long idUsuarioValido);
    }
}
