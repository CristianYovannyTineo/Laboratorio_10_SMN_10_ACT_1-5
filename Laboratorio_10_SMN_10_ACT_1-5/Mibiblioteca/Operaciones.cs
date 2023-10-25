using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10_SMN_10_ACT_1_5.Mibiblioteca
{
    internal class Operaciones
    {
        class Program
        {
            public static Dictionary<string, int> ventasProductos = new Dictionary<string, int>()
            {
             { "mphone 3000", 0 },{ "mpad 3500", 0 },{ "mapbrook 3800", 0 },{ "mwatch 8000", 0 }
            };

            static void Main()
            {
                bool salir = false;

                while (!salir)
                {
                    Console.Clear();
                    MenuProductos();
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            RealizarVenta("mphone 3000");break;
                        case 2:
                            RealizarVenta("mpad 3500");break;
                        case 3:
                            RealizarVenta("mapbrook 3800");break;
                        case 4:
                            RealizarVenta("mwatch 8000");break;
                        case 5:
                            salir = true;break;
                        default:
                            Console.WriteLine("Intente denuevo");break;
                    }
                }

                MostrarReporte();
            }

            public static void MenuProductos()
            {
                Console.WriteLine("===================\n"+
                "Productos de mphone\n"+
                "===================\n"+
                "1: Ventas de mphone 3000\n"+
                "2: Ventas de mpad 3500\n"+
                "3: Ventas de mapbrook 3800\n"+
                "4: Ventas de mwatch 8000\n"+
                "5: Salir\n"+
                "===================\n"+
                "Ingrese una opción: ");
            }

            public static void RealizarVenta(string producto)
            {
                Console.Clear();
                Console.WriteLine($"=======================\n"+
                $"Registrar Venta de {producto}\n"+
                "=======================\n"+
                "1: Registrar Venta\n"+
                "2: Registrar Devolución\n"+
                "3: Menu Principal\n"+
                "=====================\n"+
                "Ingrese una opción: \n");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    ventasProductos[producto]++;
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
                else if (opcion == 2)
                {
                    RealizarDevolucion(producto);
                }
            }

            public static void  RealizarDevolucion(string producto)
            {
                Console.Clear();
                Console.WriteLine($"=======================\n"+
                $"Registrar Devolución de {producto}\n"+
                "=======================\n"+
                $"Se va a registrar la devolución de {producto}. ¿Desea Continuar?\n"+
                "1: Sí\n"+
                "2: No\n"+
                "=====================\n"+
                "Ingrese una opción: \n");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    ventasProductos[producto]--;
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }

            public static void MostrarReporte()
            { 
                Console.Clear();
                Console.WriteLine("===============================\n"+
                "Reporte final\n"+
                "===============================\n"+
                "Productos Vendidos  | Cantidad \n"+
                "...............................\n");
                foreach (var producto in ventasProductos)
                {
                    Console.WriteLine($"{producto.Key,-19} | {producto.Value}");
                }
                Console.WriteLine("................................");
                int totalVentas = ventasProductos.Values.Sum();
                Console.WriteLine($"Total               | {totalVentas}");
                Console.WriteLine("Enter para salir.");
                Console.ReadLine();
            }
        }
    }
}
