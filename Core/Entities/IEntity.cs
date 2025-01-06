namespace Core.Entities
{
    public interface IEntity
    {
        int Id { get; }
        DateTime CreatedTime { get; }
        DateTime UpdatedTime { get; set; }
    }
}