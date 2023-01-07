using Core.Interface.Repositorio;
using Data;
using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorios
{
    public class RepositoryUsuarios : RepositoryBase<authusuario>, IRepositoryUsuarios
    {
        private readonly SqlContext _sqlContext;
        private static IQueryable<authusuario> _retorno;
        public RepositoryUsuarios(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public authusuario GetBy(string email, string senha)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.email == email && x.senha == senha).FirstOrDefault();
        }

        public authusuario GetById(long idUsuario)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.Id == idUsuario).FirstOrDefault();

        }
        public authusuario GetBy(string usuario)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.usuario == usuario).FirstOrDefault();

        }

        public authusuario GetByEmail(string email)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.email == email).FirstOrDefault();
        }
        public authusuario GetByEmailPassword(string email, string password)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.email == email && x.senha == password).FirstOrDefault();

        }

        public IEnumerable<authusuario> GetByFiltro(string usuario, string email, int? situacao, int? administrador, long? grupo)
        {
            _retorno = _sqlContext.authusuario.Include(x => x.authgrupo_nav).OrderBy(x => x.usuario).AsQueryable();
            _retorno = FiltroUsuario(usuario);
            _retorno = FiltroEmail(email);
            _retorno = FiltroSituacao(situacao);
            _retorno = FiltroAdministrador(administrador);
            _retorno = FiltroGrupo(grupo);

            return _retorno;
        }

        private IQueryable<authusuario> FiltroGrupo(long? grupo)
        {
            if (grupo != null)
                return _retorno = _retorno.Where(x => x.grupo == grupo).AsQueryable();
            return _retorno;
        }

        private IQueryable<authusuario> FiltroAdministrador(int? administrador)
        {
            if (administrador != null)
                return _retorno = _retorno.Where(x => x.administrador == administrador).AsQueryable();
            return _retorno;
        }

        private IQueryable<authusuario> FiltroSituacao(int? situacao)
        {
            if (situacao != null)
                return _retorno = _retorno.Where(x => x.situacao == situacao).AsQueryable();
            return _retorno;
        }

        private IQueryable<authusuario> FiltroEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
                return _retorno = _retorno.Where(x => x.email.Contains(email)).AsQueryable();
            return _retorno;
        }

        private IQueryable<authusuario> FiltroUsuario(string usuario)
        {
            if (!string.IsNullOrEmpty(usuario))
                return _retorno = _retorno.Where(x => x.usuario.Contains(usuario)).AsQueryable();
            return _retorno;
        }

        public authusuario GetByCpf(string cpf)
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .Where(x => x.Cpf == cpf).FirstOrDefault();
        }

        public IEnumerable<authusuario> GetAll()
        {
            return _sqlContext.authusuario
                .Include(x => x.authgrupo_nav)
                .OrderBy(x => x.usuario);
        }

        public authusuario UpdateUsuario(authusuario usuario)
        {
            var result = _sqlContext.authusuario.Include(x => x.authgrupo_nav).SingleOrDefault(x => x.Id == usuario.Id);
            if (result != null)
            {
                result.email = usuario.email;
                result.Cpf = usuario.Cpf;
                result.usuario = usuario.usuario;
                result.situacao = usuario.situacao;
                result.administrador = usuario.administrador;
                result.grupo = usuario.grupo;
                result.senha = usuario.senha;

                _sqlContext.SaveChanges();
                return _sqlContext.authusuario.SingleOrDefault(x => x.Id == usuario.Id);
            }
            else
            {
                return null;
            }
        }
    }
}
