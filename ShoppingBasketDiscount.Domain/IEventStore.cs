
namespace ShoppingBasketDiscount.Domain;

public interface IEventStore
{
    void AppendEvent(Guid aggregateId,object eventData);
    TEntity GetEntity<TEntity>(Guid aggregateId) where TEntity : AggregateRoot , new();
    Task SaveChangesAsync();
}
