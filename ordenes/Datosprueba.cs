using System;
using System.Collections.Generic;
public class DatosdePruebas
{
    public List<Producto> ListadeProducto { get; set; }
    public List<Cliente> ListadeCliente { get; set; }
    public List<Vendedor> ListadeVendedor { get; set; }
    

    public DatosdePruebas()
    {
        ListadeProducto = new List<Producto>();
        cargarProducto();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedores>();
        cargarVendedores();

    }

    private void cargarProducto()
    {
        Producto p1 = new Producto (1, "Mouse", 250);
        ListadeProducto.Add(p1); 
        Producto p2 = new Producto (2, "Monito", 250);
        ListadeProducto.Add(p2);
        Producto p3 = new Producto (3, "Teclado", 250);
        ListadeProducto.Add(p3);  
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        foreach (var producto in ListadeProducto)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion +  " | " + producto.Precio);
        }
        Console.ReadLine();
    }
}