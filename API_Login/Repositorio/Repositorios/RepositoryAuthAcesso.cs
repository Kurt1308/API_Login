using Core.Interface.Repositorio;
using Data;
using Dominio.Entidade;
using Repositorio.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositorios
{
    public class RepositoryAuthAcesso: RepositoryBase<authacesso>, IRepositoryAuthAcesso
    {
        private readonly SqlContext _sqlContext;
        private static IQueryable<authacesso> _retorno;
        public RepositoryAuthAcesso(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public IEnumerable<authacesso> GetAll()
        {
            return _sqlContext.authacesso
                .OrderBy(x => x.descricaoPermissao);
        }
        public authacesso GetById(long idAuthAcesso)
        {
            return _sqlContext.authacesso
                .Where(x => x.Id == idAuthAcesso).FirstOrDefault();
        }
        public authacesso GetBy(string acessoPermissao)
        {
            return _sqlContext.authacesso
                .Where(x => x.acessoPermissao == acessoPermissao).FirstOrDefault();
        }
        public IEnumerable<authacesso> GetByFiltro(string acessoPermissao, string descricaoPermissao, int? situacao)
        {
            _retorno = _sqlContext.authacesso.OrderBy(x => x.Id).AsQueryable();
            _retorno = FiltroAcessoPermissao(acessoPermissao);
            _retorno = FiltroDescricaoPermissao(descricaoPermissao);
            _retorno = FiltroSituacao(situacao);

            return _retorno.OrderBy(x => x.descricaoPermissao);
        }

        private IQueryable<authacesso> FiltroSituacao(int? situacao)
        {
            if (situacao != null)
                return _retorno = _retorno.Where(x => x.situacao == situacao).AsQueryable();
            return _retorno;
        }
        private IQueryable<authacesso> FiltroAcessoPermissao(string acessoPermissao)
        {
            if (!string.IsNullOrEmpty(acessoPermissao))
                return _retorno = _retorno.Where(x => x.acessoPermissao.Contains(acessoPermissao)).AsQueryable();
            return _retorno;
        }

        private IQueryable<authacesso> FiltroDescricaoPermissao(string descricaoPermissao)
        {
            if (!string.IsNullOrEmpty(descricaoPermissao))
                return _retorno = _retorno.Where(x => x.descricaoPermissao.Contains(descricaoPermissao)).AsQueryable();
            return _retorno;
        }
        public authacesso UpdateAuthAcesso(authacesso authAcesso)
        {
            var result = _sqlContext.authacesso.SingleOrDefault(x => x.Id == authAcesso.Id);
            if (result != null)
            {
                result.acessoPermissao = authAcesso.acessoPermissao;
                result.descricaoPermissao = authAcesso.descricaoPermissao;
                result.situacao = authAcesso.situacao;

                _sqlContext.SaveChanges();
                return _sqlContext.authacesso.SingleOrDefault(x => x.Id == authAcesso.Id);
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<authacesso> GetAllAcessoUsuario(long idUsuarioValido)
        {
            var IqueryAcessos = (from usuario in _sqlContext.authusuario
                                     join grupo in _sqlContext.authgrupo on usuario.grupo equals grupo.Id
                                     join grupo_acesso in _sqlContext.authgrupoxacesso on grupo.Id equals grupo_acesso.grupo
                                     join acesso in _sqlContext.authacesso on grupo_acesso.acessopermissao equals acesso.Id
                                     where usuario.Id == idUsuarioValido
                                        && acesso.situacao == 1
                                     select new authacesso
                                     {
                                         Id = acesso.Id,
                                         acessoPermissao = acesso.acessoPermissao,
                                         descricaoPermissao = acesso.descricaoPermissao,
                                         NomeExibicao = acesso.NomeExibicao,
                                         ordemExibicao = acesso.ordemExibicao,
                                         situacao = acesso.situacao,
                                         NomeComposto = $"{acesso.ordemExibicao.ToString("D5")}_{acesso.acessoPermissao}${acesso.NomeExibicao}"
                                     }).OrderBy(x => x.ordemExibicao);

            return IqueryAcessos;
        }
    }
}
