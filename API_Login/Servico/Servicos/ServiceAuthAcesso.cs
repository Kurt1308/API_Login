using Core.Interface.Repositorio;
using Core.Interface.Servicos;
using Dominio.Entidade;
using Servico.Servicos;
using System.Collections.Generic;
using System.Linq;

namespace Service.Servicos
{
    public class ServiceAuthAcesso : ServiceBase<authacesso>, IServiceAuthAcesso
    {
        private readonly IRepositoryAuthAcesso _repositoryAuthAcesso;
        public ServiceAuthAcesso(IRepositoryAuthAcesso repositoryAuthAcesso) : base(repositoryAuthAcesso)
        {
            _repositoryAuthAcesso = repositoryAuthAcesso;
        }
        public List<authacesso> GetByFiltro(string acessoPermissao, string descricaoPermissao, int? situacao)
        {
            return _repositoryAuthAcesso.GetByFiltro(acessoPermissao, descricaoPermissao, situacao).ToList();
        }

        public authacesso UpdateAuthAcesso(authacesso authAcesso)
        {
            return _repositoryAuthAcesso.UpdateAuthAcesso(authAcesso);
        }

        public List<authacesso> GetAll()
        {
            return _repositoryAuthAcesso.GetAll().ToList();
        }
        public authacesso GetById(long idAuthAcesso)
        {
            return _repositoryAuthAcesso.GetById(idAuthAcesso);
        }
        public authacesso GetBy(string acessoPermissao)
        {
            return _repositoryAuthAcesso.GetBy(acessoPermissao);
        }
        public IEnumerable<authacesso> GetAllAcessoUsuario(long idUsuarioValido)
        {
            return _repositoryAuthAcesso.GetAllAcessoUsuario(idUsuarioValido);
        }
    }
}
