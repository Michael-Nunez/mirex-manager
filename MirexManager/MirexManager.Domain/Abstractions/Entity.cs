namespace MirexManager.Domain.Abstractions;

public abstract class Entity
{
    public int Id { get; set; }
    public Entity(int id)
    {
        Id = id;
    }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
