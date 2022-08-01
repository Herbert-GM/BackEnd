/*

- Ejercicio 1 

Crea una estructura de datos para un cliente con estos campos:

	- Nombre completo
	- Teléfono
	- Dirección
	- Email
	- Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */

Cliente cliente1 = new Cliente("Herbert", 974831745, "Casma", "herbertperugm@gmail.com", "Sí");
Console.WriteLine(cliente1);
public class Cliente
{
	public Cliente(string Nombre, int Telefono, string Direccion, string Email, string nuevoCliente)
    {
		this.Nombre = Nombre;
		this.Telefono = Telefono;
		this.Direccion = Direccion;
		this.Email = Email;
		this.nuevoCliente = nuevoCliente;
    }

	public string Nombre { get; set; }
	public int Telefono { get; set; }
	public string Direccion { get; set; }
	public string Email { get; set; }
	public string nuevoCliente { get; set; }

	public override string ToString() => $"Nombre: {Nombre}\n" +
		$"Telefono: {Telefono}\n" +
		$"Dirección: {Direccion}\n" +
		$"Email: {Email}\n" +
		$"Cliente Nuevo: {nuevoCliente}";

}