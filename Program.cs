using System;

namespace POS
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = (" ");

            while (true)
            {

                Console.Clear();
                Console.WriteLine("                   *******************************************************************************************************");
                Console.WriteLine("                   *                                ====================================                                 *");
                Console.WriteLine("                   *                                ||       Valeria`s Tecnology      ||                                 *");
                Console.WriteLine("                   *                                ====================================                                 *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                ======>     1 - Lista de Productos                                   *");
                Console.WriteLine("                   *                                ======>     2 - Crear Reporte                                        *");
                Console.WriteLine("                   *                                ======>     3 - Lista de Clientes                                    *");
                Console.WriteLine("                   *                                ======>     4 - Lista de Vendedores                                  *");
                Console.WriteLine("                   *                                ======>     5 - Reporte de Ventas                                    *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                                                                                     *");
                Console.WriteLine("                   *                                ======>     0 - Salir del Sistema                                    *");
                Console.WriteLine("                   *******************************************************************************************************");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;

                    case "2":
                        Console.Clear();
                        datos.crearOrden();
                        break;

                    case "3":
                        datos.ListarClientes();
                        break;

                    case "4":
                        datos.ListarVendedores();
                        break;
                    case "5":
                        Console.Clear();
                        datos.ListarOrdenes();
                        break;
                    default:
                        break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }
        }
    }
}
