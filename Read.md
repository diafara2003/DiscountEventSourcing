# Shopping Basket Discount List Test

## Shopping
Items in a shopping basket have a unit price and quantity. Write code that will allow you to:

find out the quantity of a particular item in the basket
calculate the total price of the whole basket, including any applicable discount
Normally the total price is the sum of unit price * quantity for all the items. If you buy in bulk you get a discount:

If total basket value > $100, apply a 5% discount
If total basket value > $200, apply a 10% discount
Example
Item A: price $10, quantity 5
Item B: price $25, quantity 2
Item C: price $9.99, quantity 6
This basket qualifies for a 5% discount and the total price is $151.94

#productos

Chocorramo ==> 10
Cocacola==> 25
Oreo==> 9.99


💥==>red
✅==>green
♻️==>refactor

[x] - Debo poder agregar un producto a la compra con la cantidad
[x] - Debo poder mostrar la cantidad de un producto en la compra
	[] - Debo poder mostrar la cantidad de un producto en 0 en la compra ? - preguntar
[ ] - Debo poder mostrar el precio total de la compra
	[] - Debo_poder_mostrar_dos__2_productos_y_el_precio_total_de_la_compra_es_de_70
[ ] - Debo poder hacer un descuento del 5% cuando el valor total es mayor a 100
[ ] - Debo poder hacer un descuento del 10% cuando el valor total es mayor a 200
[ ] - Debo mostrar el precio total de la compra La compra califica para un descuento del 5% y el precio total es de 151.94
[ ] - Debo mostrar el precio total de la compra La compra califica para un descuento del 10% y el precio total es de 180.00
[ ] - Debo mostrar el precio total de la compra La compra no califica para un descuento y el precio total es de 70.00

[] - Copilot recomendo estas pruebas

1.	Prueba con una cesta vacía:
•	Verifica que el precio total sea 0 cuando no hay productos en la cesta.
2.	Prueba con un solo producto y cantidad 1:
•	Verifica que el precio total sea igual al precio unitario del producto.
3.	Prueba con múltiples productos sin descuento:
•	Verifica que el precio total sea la suma de los precios unitarios multiplicados por sus cantidades cuando el total no califica para un descuento.
4.	Prueba con múltiples productos y un total justo en el límite del descuento:
•	Verifica que el precio total sea correcto cuando el total es exactamente $100 o $200, asegurando que el descuento se aplica correctamente.
5.	Prueba con cantidades grandes de productos:
•	Verifica que el cálculo del precio total y los descuentos se manejen correctamente con cantidades grandes de productos.