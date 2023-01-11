using Core.Interface.Repositorio;
using Core.Interface.Servicos;
using Dominio.Entidade;

namespace Servico.Servicos
{
    public class ServiceUsuarios : ServiceBase<authusuario>, IServiceUsuarios
    {
        private readonly IRepositoryUsuarios _repositoryUsuarios;

        public ServiceUsuarios(IRepositoryUsuarios repositoryUsuarios) : base(repositoryUsuarios)
        {
            _repositoryUsuarios = repositoryUsuarios;
        }

        public authusuario GetBy(string email, string senha)
        {
            return _repositoryUsuarios.GetBy(email, senha);
        }
    }
}
