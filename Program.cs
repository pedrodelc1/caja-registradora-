Console.WriteLine("Hello, World!");
const string nombreDelkiosco = "Kiosco EL RECREO";

Console.WriteLine("nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. {nombreDelkiosco} tiene la caja abierta.");

Console.WriteLine("Nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.WriteLine("Precio del producto: ");
Decimal precio = Decimal.Parse(Console.ReadLine());
Console.WriteLine($"Se creo el producto {nombreProducto}.");

Console.ReadLine();