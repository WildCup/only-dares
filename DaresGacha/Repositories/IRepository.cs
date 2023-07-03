namespace DaresGacha.Services;

public interface IRepository<T> where T : Base
{
    Task<int> Add(Base entity);

    Task Delete(int id);

    Task<T?> Get(int id);

    Task<IEnumerable<T>> GetAll();

    Task Update(Base entity);
}
