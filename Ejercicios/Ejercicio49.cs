using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio49
    {
// 49. Cola de atención (Simulación) - Simular una cola de atención bancaria con List<string>.
// Permitir: llegar cliente (Add), atender cliente (quitar primero con RemoveAt(0)), ver siguiente y ver estado de la cola.
// Logica: Aplica el modelo FIFO (primero en entrar, primero en salir) utilizando Add para llegada y RemoveAt(0) para despachar.
        public void ColaBancaria()
        {
            Console.WriteLine("Simulador de cola de atencion bancaria");
            List<string> cola = new List<string>();
            int opcion = -1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Llegada de cliente (formarse)");
                Console.WriteLine("2. Atender cliente (sale el primero)");
                Console.WriteLine("3. Ver proximo cliente en turno");
                Console.WriteLine("4. Ver estado completo de la fila");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion:");

                opcion = int.TryParse(Console.ReadLine() ?? "", out int opt) ? opt : -1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca el nombre del cliente:");
                        string cliente = (Console.ReadLine() ?? "").Trim();

                        if (string.IsNullOrEmpty(cliente))
                        {
                            cliente = "Cliente sin registrar";
                        }

                        cola.Add(cliente);
                        Console.WriteLine($"El cliente '{cliente}' ha tomado su lugar en la posicion {cola.Count}");
                        break;

                    case 2:
                        if (cola.Count == 0)
                        {
                            Console.WriteLine("No hay clientes en espera para atender");
                        }
                        else
                        {
                            string atendido = cola[0];
                            cola.RemoveAt(0);
                            Console.WriteLine($"Atendiendo en ventanilla a: {atendido}");
                            Console.WriteLine($"Clientes restantes en la fila: {cola.Count}");
                        }
                        break;

                    case 3:
                        if (cola.Count == 0)
                        {
                            Console.WriteLine("La fila esta vacia");
                        }
                        else
                        {
                            Console.WriteLine($"Siguiente cliente a pasar: {cola[0]}");
                        }
                        break;

                    case 4:
                        if (cola.Count == 0)
                        {
                            Console.WriteLine("Actualmente no hay nadie formado en ventanilla");
                        }
                        else
                        {
                            Console.WriteLine("Clientes en espera por orden de llegada:");
                            for (int i = 0; i < cola.Count; i++)
                            {
                                Console.WriteLine($"Turno {i + 1}: {cola[i]}");
                            }
                        }
                        break;

                    case 0:
                        Console.WriteLine("Cerrando atencion de ventanilla");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 0);
        }
    }
}