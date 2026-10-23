using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio50
    {
// 50. Registro de ventas - Gestionar ventas usando listas paralelas para producto, precio, cantidad.
// Menú: registrar venta, mostrar todas, venta con mayor total, venta con menor total, promedio y total general.
// Logica: Sincroniza 3 colecciones dinámicas por su índice y calcula acumulaciones, extremos y promedios monetarios.
        public void RegistroVentas()
        {
            Console.WriteLine("Sistema de registro de ventas con listas paralelas");
            List<string> productos = new List<string>();
            List<decimal> precios = new List<decimal>();
            List<int> cantidades = new List<int>();
            int opcion = -1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Registrar nueva venta");
                Console.WriteLine("2. Mostrar todas las ventas registradas");
                Console.WriteLine("3. Ver venta con mayor y menor monto total");
                Console.WriteLine("4. Ver total general y promedio de ventas");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion:");

                opcion = int.TryParse(Console.ReadLine() ?? "", out int opt) ? opt : -1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca la descripcion del producto:");
                        string nombre = (Console.ReadLine() ?? "").Trim();
                        if (string.IsNullOrEmpty(nombre))
                        {
                            nombre = "Articulo general";
                        }

                        Console.WriteLine("Introduzca el precio unitario:");
                        decimal precio = decimal.TryParse(Console.ReadLine() ?? "", out decimal p) ? p : 0.0m;

                        Console.WriteLine("Introduzca la cantidad vendida:");
                        int cantidad = int.TryParse(Console.ReadLine() ?? "", out int c) ? c : 0;

                        if (precio <= 0 || cantidad <= 0)
                        {
                            Console.WriteLine("El precio y la cantidad deben ser mayores a cero. No se registro la venta.");
                        }
                        else
                        {
                            productos.Add(nombre);
                            precios.Add(precio);
                            cantidades.Add(cantidad);
                            Console.WriteLine("Venta registrada con exito");
                        }
                        break;

                    case 2:
                        if (productos.Count == 0)
                        {
                            Console.WriteLine("No hay ventas registradas en el sistema");
                        }
                        else
                        {
                            Console.WriteLine("Listado de ventas:");
                            for (int i = 0; i < productos.Count; i++)
                            {
                                decimal subtotal = precios[i] * cantidades[i];
                                Console.WriteLine($"{i + 1}. Producto: {productos[i]} | Precio: L. {precios[i]:N2} | Cant: {cantidades[i]} | Subtotal: L. {subtotal:N2}");
                            }
                        }
                        break;

                    case 3:
                        if (productos.Count == 0)
                        {
                            Console.WriteLine("No hay ventas para calcular extremos");
                        }
                        else
                        {
                            int indmayor = 0;
                            int indmenor = 0;
                            decimal montomayor = precios[0] * cantidades[0];
                            decimal montomenor = precios[0] * cantidades[0];

                            for (int i = 1; i < productos.Count; i++)
                            {
                                decimal actual = precios[i] * cantidades[i];

                                if (actual > montomayor)
                                {
                                    montomayor = actual;
                                    indmayor = i;
                                }

                                if (actual < montomenor)
                                {
                                    montomenor = actual;
                                    indmenor = i;
                                }
                            }

                            Console.WriteLine($"Venta con mayor monto: {productos[indmayor]} con un total de L. {montomayor:N2}");
                            Console.WriteLine($"Venta con menor monto: {productos[indmenor]} con un total de L. {montomenor:N2}");
                        }
                        break;

                    case 4:
                        if (productos.Count == 0)
                        {
                            Console.WriteLine("No hay ventas registradas");
                        }
                        else
                        {
                            decimal totalacumulado = 0;
                            for (int i = 0; i < productos.Count; i++)
                            {
                                totalacumulado += precios[i] * cantidades[i];
                            }

                            decimal promedioventa = totalacumulado / productos.Count;

                            Console.WriteLine($"Total general recaudado: L. {totalacumulado:N2}");
                            Console.WriteLine($"Promedio por venta realizada: L. {promedioventa:N2}");
                            Console.WriteLine($"Cantidad de ventas procesadas: {productos.Count}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Cerrando modulo de ventas");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 0);
        }
    }
}