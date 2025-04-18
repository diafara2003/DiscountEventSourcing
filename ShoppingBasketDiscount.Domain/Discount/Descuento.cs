
namespace ShoppingBasketDiscount.Domain.Discount;

public class Descuento
{
    public static double AplicarDescuento(double Total, double Dto)
    //=> Math.Round(Total - (Total * Dto), 2); //Total Compra - Descuento
    => (Total* Dto);//Descuento aplicado


    public static double ObtenerDescuento(double totalCompra)
    {
        double dto = 0;

        if (totalCompra > 100 && totalCompra < 200) dto = 0.05;
        else if (totalCompra > 200) dto = 0.1;

        return dto;
    }
}
