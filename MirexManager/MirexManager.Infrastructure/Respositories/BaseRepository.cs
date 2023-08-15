using MirexManager.Domain.Abstractions;
using MirexManager.Infrastructure.Contexts;

namespace MirexManager.Infrastructure.Respositories;
internal class BaseRepository<T> : IRepository<T>
    where T : class
{
    private readonly ApplicationDbContext _context;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Add(entity);
    }

    public void Delete(int id)
    {
        var entity = Get(id);
        _context.Remove(entity);
    }

    public T Get(int id)
    {
        return _context.Set<T>().FirstOrDefault()!;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}