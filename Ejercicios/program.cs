using System;

namespace inventario
{
    class Program
    {
        static string [,] productos = new string [5,3]
        {
            {"001", "iPhonex", "0"},
            {"002", "Laptop", "5"},
            {"003", "Monitor", "2"},
            {"004", "Mouse", "200"},
            {"005", "Headset", "25"},
        };
        
        static void listadeproductos()
        {
            Console.Clear();
            Console.WriteLine("Listado de productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion y existencia");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i,0] + "|" + productos[i,1] + "|" + productos[i,2]  );
            }
            Console.ReadLine();

        }
        static void movimientoInventario (string codigo, int cantidad, string tipoMovimiento) 
        {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                    } else {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                }
            }
        }

        static void ingresoDeInventario() 
        {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine("Ingrese de productos al inventario");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo=Console.ReadLine();
            Console.WriteLine ("Ingrese la cantidad del producto: ");
            cantidad=Console.ReadLine();
            
            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

                static void salidaDeInventario() 
        {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine("Ingrese de productos al inventario");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo=Console.ReadLine();
            Console.WriteLine ("Ingrese la cantidad del producto: ");
            cantidad=Console.ReadLine();
            
            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }


        static void Main(string[] args)
        {

            string opcion="";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de inventario"  );
                Console.WriteLine("*********************"  );
                Console.WriteLine(""  );
                Console.WriteLine("1-Productos"  );
                Console.WriteLine("2-Ingreso de Inventario"  );
                Console.WriteLine("3-Salida de Inventario"  );
                Console.WriteLine("0-Salir"  );
                opcion=Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listadeproductos();
                        break;
                    case "2":
                        ingresoDeInventario();
                        break;
                    case "3":
                        salidaDeInventario();
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