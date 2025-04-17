
namespace ShoppingBasketDiscount.Domain.Discount;

public class DetalleCompra : AggregateRoot
{
    public Guid IdCompra { get; private set; }
    public Dictionary<TipoProducto, Producto> Productos { get; private set; } = new();
    public double TotalCompra { get; private set; }



    public void Apply(ProductoAgregado @events)
    {
        IdCompra = events.IdCompra;

        if (Productos.ContainsKey(events.producto))
        {
            Producto existingProducto = Productos[events.producto];

            Producto producto = existingProducto with
            {
                cantidad = existingProducto.cantidad + events.Cantidad
            };
            Productos[events.producto] = producto;
            TotalCompra = producto.cantidad * events.ValorProducto;
        }
        else
        {
            Productos.Add(events.producto, new Producto(events.Cantidad, events.ValorProducto));
            TotalCompra = events.Cantidad * events.ValorProducto;
        }
    }

    public void Apply(DescuentoAplicado @event)
    {
        // var descuento = TotalCompra * @event.PorcentajeDescuento;
        TotalCompra = @event.TotalCompra;
    }
}
