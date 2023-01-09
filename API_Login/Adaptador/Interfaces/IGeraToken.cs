using Dominio.Entidade;
using System.Collections.Generic;

namespace Adaptador.Interfaces
{
    public interface IGeraToken
    {
        string GerarTokenJWT(authusuario usuario, IEnumerable<authacesso> acessos);
    }
}