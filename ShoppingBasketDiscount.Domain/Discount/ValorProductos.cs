
namespace ShoppingBasketDiscount.Domain.Discount;

public  class ValorProductos
{
    public static double ObtenerDatosProducto(TipoProducto nombre)
    {
        return nombre switch
        {
            TipoProducto.Chocorramo => 10,
            TipoProducto.CocaCola => 25,
            TipoProducto.Oreo => 9.99,
            _ => throw new ArgumentOutOfRangeException(nameof(nombre), $"No se encontró información para el producto {nombre}")
        };
    }
}
