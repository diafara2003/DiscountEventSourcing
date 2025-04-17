
namespace ShoppingBasketDiscount.Domain
{
    public interface ICommandHandler<TCommand>
    {
        Task Handle(TCommand command);
    }
}
