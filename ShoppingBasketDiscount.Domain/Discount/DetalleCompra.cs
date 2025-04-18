
namespace ShoppingBasketDiscount.Domain.Discount;

public class DetalleCompra : AggregateRoot
{
    public Guid IdCompra { get; private set; }
    public Dictionary<TipoProducto, Producto> Productos { get; private set; } = new();
    public double Descuento { get; set; }
    //public double TotalCompra { get; set; }

    public double TotalCompra()
    {
        var subtotal = Productos.Sum(p => p.Value.cantidad * p.Value.PrecioUnitario);
        return Math.Round( subtotal - Descuento,2);
    }

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
            // TotalCompra = producto.cantidad * events.ValorProducto;
        }
        else
        {
            Productos.Add(events.producto, new Producto(events.Cantidad, events.ValorProducto));
            //  TotalCompra = events.Cantidad * events.ValorProducto;
        }
    }

    public void Apply(DescuentoAplicado @event)
    {
        Descuento = @event.valorDescuento;
        // var descuento = TotalCompra * @event.PorcentajeDescuento;
        //  TotalCompra = @event.TotalCompra;
    }
}
