using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregarCamisas miCamisa = new AgregarCamisas();
            Carrito miCarrito = new Carrito();
            Menu miMenu = new Menu();

            Console.WriteLine("Tienda de camisas");
            Console.WriteLine("");
            Console.WriteLine("");
            miMenu.MostrarMenu(miCamisa, miCarrito);

        }
    }
}
