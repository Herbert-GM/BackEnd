/*
 * Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo:
C#, Java, C++. Presenta la lista en consola y pide que el
usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */

Console.WriteLine("Escoge tu lenguaje: \n" +
    "1 - C# \n" +
    "2 - Java \n" +
    "3 - C++ \n" +
    "4 - JavaScript \n" +
    "5 - Python \n");

int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
switch (option)
{
    case 0:
        Console.WriteLine("C#");
        Console.WriteLine("Console.WriteLine('Hola Mundo');");
        break;

    case 1:
        Console.WriteLine("Java");
        Console.WriteLine("System.out.println('Hello World');");
        break ;

    case 2:
        Console.WriteLine("C++");
        Console.WriteLine("cout << 'Hello World' << endl;");
        Console.WriteLine("return 0;");
        break;

    case 4:
        Console.WriteLine("JavaScript");
        Console.WriteLine("console.log('Hello World')");
        break;

    case 5:
        Console.WriteLine("Python");
        Console.WriteLine("print('Hello World')");
        break;
}