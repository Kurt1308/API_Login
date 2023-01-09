using System.Threading.Tasks;

namespace Core.Interface.Servicos
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task AddAsync(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

    }
}
