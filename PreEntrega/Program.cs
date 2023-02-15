// See https://aka.ms/new-console-template for more information
using PreEntrega;
using System;

//Console.WriteLine("Hello, World!");
//Producto productoInsertar = new Producto();
//productoInsertar.descripciones = "Camisa Deportiva Negra";
//productoInsertar.costo = 120;
//productoInsertar.precioventa = 200;
//productoInsertar.stock = 8;
//productoInsertar.idusuario = 8;

//if (ManejadorProducto.insertarproducto(productoInsertar) >= 1)
//{
//    Console.WriteLine(" Se incerto el producto");
//}
//else
//{
//    Console.WriteLine(" no se pudo insertar el producto...");
//}


// hace referencia al metodo de obtenerusuario...1)
//Usuario usus= ManejadorUsuario.ObtenerUsuario(2);

// ejercicio 2, esta en manejador producto. 2)


// traer producto... 3)

//Producto p = ManejadorProducto.ObtenerProducto(1);

//List<Producto> productos = ManejadorProducto.ObtenerProductosVendidos(2);

Console.WriteLine(" ** Usuario ** ");
// Traer Usuario 
Usuario usuario = ManejadorUsuario.ObtenerUsuario(1);
Console.WriteLine($"Usuario Id: {usuario.id}, Usuario: {usuario.nombre}");

Console.WriteLine("***");

// Traer Productos
List<Producto> productos = ManejadorProducto.ObtenerProductosVendidos(1);
foreach (Producto producto in productos)
{

    Console.WriteLine($"Productos cargados por el usuario {producto.idusuario}: {producto.descripciones}");
}

Console.WriteLine("***");

Console.WriteLine(" ** Ventas ** ");

// Traer Ventas 
List<Venta> ventas = ManejadorVenta.ObtenerVentas(1);
foreach (Venta v in ventas)
{
    Console.WriteLine($"Ventas Usuario: {v.idusuario}, Id de la Venta: {v.id}");
}

Console.WriteLine("** Inicio de sesión ** ");

// Inicio de sesión 
Usuario usuarioLogin = ManejadorUsuario.ObtenerUsuarioLogin("tcasazza", "SoyTobiasCasazza");
Console.WriteLine($"Usuario: {usuarioLogin.nombre} \tApellido: {usuarioLogin.apellido} \tMail: {usuarioLogin.mail}");
// ----------------------------------------------------------------------------







