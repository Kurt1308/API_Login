using Core.Interface.Repositorio;
using Core.Interface.Servicos;
using Dominio.Entidade;
using System.Collections.Generic;
using System.Linq;

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

        public authusuario GetBy(string usuario)
        {
            return _repositoryUsuarios.GetBy(usuario);
        }

        public authusuario GetByCpf(string cpf)
        {
            return _repositoryUsuarios.GetByCpf(cpf);
        }

        public authusuario GetByEmail(string email)
        {
            return _repositoryUsuarios.GetByEmail(email);
        }
        public authusuario GetByEmailPassword(string email, string password)
        {
            return _repositoryUsuarios.GetByEmailPassword(email, password);
        }
        public List<authusuario> GetByFiltro(string usuario, string email, int? situacao, int? administrador, long? grupo)
        {
            return _repositoryUsuarios.GetByFiltro(usuario, email, situacao, administrador, grupo).ToList();
        }

        public authusuario UpdateUsuario(authusuario usuario)
        {
            return _repositoryUsuarios.UpdateUsuario(usuario);
        }

        public List<authusuario> GetAll()
        {
            return _repositoryUsuarios.GetAll().ToList();
        }
        public authusuario GetById(long idUsuario)
        {
            return _repositoryUsuarios.GetById(idUsuario);
        }
    }
}
