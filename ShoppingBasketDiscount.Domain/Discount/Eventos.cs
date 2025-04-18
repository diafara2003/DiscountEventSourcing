

namespace ShoppingBasketDiscount.Domain.Discount;

public record ProductoAgregado(Guid IdCompra, TipoProducto producto, int Cantidad,double ValorProducto );
    
public record DescuentoAplicado(Guid IdCompra,double valorDescuento);