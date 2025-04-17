
namespace ShoppingBasketDiscount.Domain.Discount.Comandos;


public record AgregarProducto(Guid IdCompra, TipoProducto Producto, int Cantidad);
public class AgregarProductoHandler(IEventStore eventStore) : ICommandHandler<AgregarProducto>
{
    public Task Handle(AgregarProducto command)
    {
        var compra = eventStore.GetEntity<DetalleCompra>(command.IdCompra);

        double valorProducto = ValorProductos.ObtenerDatosProducto(command.Producto);

        var crearProducto = new ProductoAgregado(command.IdCompra, command.Producto, command.Cantidad, valorProducto);

        eventStore.AppendEvent(command.IdCompra, crearProducto);

        double totalCompra = compra.TotalCompra + (command.Cantidad * valorProducto);

        double dto = Descuento.ObtenerDescuento(totalCompra);

        if (dto > 0)
        {
            double totalCompraConDescuento = Descuento.AplicarDescuento(totalCompra, dto);
            var descuento = new DescuentoAplicado(command.IdCompra, totalCompraConDescuento);
            eventStore.AppendEvent(command.IdCompra, descuento);
        }

        return Task.CompletedTask;
    }
}
