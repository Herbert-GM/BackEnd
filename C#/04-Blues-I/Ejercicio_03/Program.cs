/*
 * Ejercicio 3 - For

	Escribe un programa que realice estos pasos:

	Reciba 3 datos:
	ancho
	alto
	relleno o no

	Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas
	y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

	En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

	Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

	Input: 2,2,2, relleno = true

	Output:

	** **

	** **

	Input: 3, 4, 1, relleno = false

	Output:

	***

	* *

	* *

	***
 */

Console.WriteLine("Ingrese los siguientes datos");
Console.Write("Filas: ");
int filas = Convert.ToInt32(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = Convert.ToInt32(Console.ReadLine());
Console.Write("Dibujar: ");
int repetir = Convert.ToInt32(Console.ReadLine());
Console.Write("Relleno: Y/N ");
string relleno = Console.ReadLine();

for (int r = 0; r < repetir; r++)
{
	if (relleno.ToLower() != "n")
	{
		for (int i = 0; i < filas; i++)
		{
			for (int j = 0; j < columnas; j++)
			{
				if (j == columnas - 1)
				{
					Console.WriteLine("*");
					//Console.WriteLine("C" + j + "F" + i);
				}
				else
				{
					Console.Write("*");
					//Console.Write("C" + j + "F" + i + " ");
				}
			}
		}

		Console.WriteLine();

	}
	else
	{
		for (int i = 0; i < filas; i++)
		{
			for (int j = 0; j < columnas; j++)
			{
				if (i == 0 || i == filas - 1 || j == 0 || j == columnas - 1)
				{
					if (j == columnas - 1)
					{
						Console.WriteLine("*");
						//Console.WriteLine("C" + j + "F" + i);
					}
					else
					{
						Console.Write("*");
						//Console.Write("C" + j + "F" + i + " ");
					}
				}
				else
				{
					Console.Write(" ");
				}
			}
		}

		Console.WriteLine();
	}
}