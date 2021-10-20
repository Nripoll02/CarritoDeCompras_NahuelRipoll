using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Camisas miCamisa = new Camisas();
            Carrito miCarrito = new Carrito();
            Menu miMenu = new Menu();

            Console.WriteLine("Tienda de camisas");
            Console.WriteLine("");
            Console.WriteLine("");
            miMenu.MostrarMenu(miCamisa, miCarrito);

        }
    }
}
