/*
	Operadores Determina los operadores para verificar las siguientes condiciones:

	Un número es mayor o igual a 18

	Un char es ‘a’

	Se cumplen dos conciones a la vez (ambas verdaderas)

	Se cumple una de dos condiciones a la vez (una true y otra false)

	Nota: puedes escribir estos datos por consola si prefieres verlos.
	La idea del ejercicio es almacenar los datos en los tipos más adecuados.

 */

short n1 = 30;
int criterioNumero = 18;
Console.WriteLine(n1 > criterioNumero);

char letra = 'a';
char criterioLetra = 'a';
Console.WriteLine(letra == criterioLetra);

Console.WriteLine(n1>criterioNumero && letra == criterioLetra);
Console.WriteLine(n1>criterioNumero && letra != criterioLetra);