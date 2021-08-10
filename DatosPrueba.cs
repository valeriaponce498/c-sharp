using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos{ get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }
    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Audifonos", 200);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Memoria USB", 1000);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Cable VGA", 500);
        ListadeProductos.Add(p6);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Marina", "9893-0576");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Cecilia", "9876-5431");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Gerardo", "9567-2341");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Elsa", "9578-9900");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Sergio", "9998-0765");
        ListadeClientes.Add(c5);

        Cliente c6 = new Cliente(6, "Enrique", "9534-3434");
        ListadeClientes.Add(c6);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Valentina", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Uvaldina", "V002");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3, "Jovany", "V003");
        ListadeVendedores.Add(v3);

        Vendedor v4 = new Vendedor(4, "Marcio", "V004");
        ListadeVendedores.Add(v4);

        Vendedor v5 = new Vendedor(5, "Valeria", "V005");
        ListadeVendedores.Add(v5);

        Vendedor v6 = new Vendedor(6, "Armando", "V006");
        ListadeVendedores.Add(v6);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("||        Lista de Productos      ||                                     ");
        Console.WriteLine("====================================                                     ");
        Console.WriteLine(" ");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("||        Lista de Clientes       ||                                     ");
        Console.WriteLine("====================================                                     ");
        Console.WriteLine(" ");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("||        Lista de Vendedores     ||                                     ");
        Console.WriteLine("====================================                                     ");
        Console.WriteLine(" ");

        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }
    public void crearOrden()
    {
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("||        Creando Reporte         ||                                     ");
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("Ingrese el codigo del cliente:                                      ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado                                              ");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Cliente:   "+cliente.Nombre);   
            Console.WriteLine("");
        }

        Console.WriteLine("                                ");
        Console.WriteLine("Ingrese el codigo del vendedor:                               ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado                                               ");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Vendedor: " + vendedor.Nombre   );
            Console.WriteLine("");
        }
        
        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        {
           Console.WriteLine("                                ");
           Console.WriteLine("Ingrese el producto:           ");
           string codigoProducto = Console.ReadLine();
           Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado     ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Producto agregado: " + producto.Descripcion +" | " + "Con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
                Console.WriteLine("");
            }

           Console.WriteLine("¿Desea continuar? s/n:          ");
           string continuar = Console.ReadLine();
           Console.WriteLine("");
           if (continuar.ToLower() == "n")
           {
               break;
           }
        }
        Console.WriteLine("====>    SubTotal: " + nuevaOrden.Subtotal);
        Console.WriteLine("====>    Impuesto: " + nuevaOrden.Impuesto );
        Console.WriteLine("====>    Total: " + nuevaOrden.Total);
        Console.ReadLine();
    }
    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("====================================                                     ");
        Console.WriteLine("||        Reporte de Ventas       ||                                     ");
        Console.WriteLine("====================================                                     ");
        Console.WriteLine(" ");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("Codigo |    Fecha    |  Impuesto  |  Total");
            Console.WriteLine("===========================================");
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Impuesto + " | " + orden.Total);
            Console.WriteLine(" ");
            Console.WriteLine("Cliente | Vendedor");
            Console.WriteLine("===================");
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            Console.WriteLine(" ");

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
            Console.WriteLine("Producto  | Cantidad |  Precio ");
            Console.WriteLine("==============================");
                Console.WriteLine(detalle.Producto.Descripcion + "   |    " + detalle.Cantidad + "     |     " + detalle.Precio);
            }
            Console.WriteLine(" ");
        }

        Console.ReadLine();
    }
}