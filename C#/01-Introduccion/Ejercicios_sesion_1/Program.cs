// Ejercicio 1
// Escribe un programa que reciba tu nombre y lo escriba por consola.
Console.WriteLine("Escribe tu nombre");

string nombre = Console.ReadLine();

Console.WriteLine("Bienvenido: " + nombre);


//Ejercicio 2
//Escribe un programa que tome la hora y la escriba por pantalla.

string datetime = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine("La hora actual es: " + datetime);