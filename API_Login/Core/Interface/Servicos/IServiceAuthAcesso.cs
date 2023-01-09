using Dominio.Entidade;
using System.Collections.Generic;

namespace Core.Interface.Servicos
{
    public interface IServiceAuthAcesso : IServiceBase<authacesso>
    {
        List<authacesso> GetAll();
        List<authacesso> GetByFiltro(string acessoPermissao, string descricaoPermissao, int? situacao);
        authacesso GetById(long idAuthAcesso);
        authacesso GetBy(string acessoPermissao);
        authacesso UpdateAuthAcesso(authacesso authAcesso);
        IEnumerable<authacesso> GetAllAcessoUsuario(long idUsuarioValido);
    }
}