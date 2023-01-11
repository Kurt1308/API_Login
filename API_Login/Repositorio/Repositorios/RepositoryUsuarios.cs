using Core.Interface.Repositorio;
using Data;
using Dominio.Entidade;
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
                .Where(x => x.email == email && x.senha == senha).FirstOrDefault();
        }
    }
}
