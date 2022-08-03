/*
 * - Ejercicio 1 - If

Escribe un programa que:

	+ Pida datos a un cliente: Nombre, email, cupón
	
	+ Determine si un cliente tiene un cupon descuento
	
	+ Muestre un precio rebajado en función del descuento
	
	+ Muestre el precio de un producto sin descuento si no hay cupón

	Nota: puedes poner un precio fijo de un producto o uno variable.
 */

Console.WriteLine("Ingrese los siguientes datos");

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.WriteLine("Cupón 0/5/10");
int descuento = Convert.ToInt32(Console.ReadLine());

double precio = 100;

Console.WriteLine($"Precio sin descuento: {precio}");


if (descuento == 5)
{
    Console.WriteLine($"Descuento: {(precio * 0.05)}");
    Console.WriteLine("Nuevo precio: {0}", (precio - (precio * 0.05)));
}
else if (descuento == 10)
{
	Console.WriteLine($"Descuento: {(descuento * 0.1)}");
	Console.WriteLine("Nuevo precio: {0}", (precio - (precio * 0.1)));
}
else
{
	Console.WriteLine($"Precio: {descuento}");
}