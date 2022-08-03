/*
 * Ejercicio 2 - Do while

	Escribe un programa que realice estos pasos:

	Reciba al menos un número por consola

	Determine si el número es positivo o negativo

	Presente un contador para cada tipo (positivo y negativo).

	Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
	Tienes completa libertad para elegir el formato de la salida.
 */
int nPositivos = 0;
int nNegativos = 0;
int? numero = null;

do
{
    Console.WriteLine("Ingrese un número");
	numero = Convert.ToInt32(Console.ReadLine());

    if (numero != 0)
    {
        if (numero > 0)
        {
            nPositivos++;
        }
        else
        {
            nNegativos++;
        }
    }

} while (numero != 0);

Console.WriteLine($"Cantidad de números positivos: {nPositivos}");
Console.WriteLine($"Cantidad de números negativos: {nNegativos}");