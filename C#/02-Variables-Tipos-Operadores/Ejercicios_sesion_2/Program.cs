//Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
//usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

string? nombre;
string? apellido;
string? sabeProgramar;
int? edad;

Console.WriteLine("Por favor ingrese sus datos:");
Console.Write("Nombre: ");
nombre = Console.ReadLine();

Console.Write("Apellido: ");
apellido = Console.ReadLine();

Console.Write("Edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("¿Sabes Programar?: ");
sabeProgramar = Console.ReadLine();

Console.WriteLine("Bienvenido " + nombre + " " + apellido + " a la edad de " + edad + " años " + sabeProgramar + " está programando");