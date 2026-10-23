using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio45
    {
// 45. Operaciones básicas con listas - Crear una lista de enteros. Implementar menú para: agregar elemento,
// insertar en posición, eliminar por valor, eliminar por índice, ordenar ascendente y descendente, y limpiar lista.
// Logica: Gestiona una List<int> aplicando los métodos nativos Add, Insert, Remove, RemoveAt, Sort, Reverse y Clear dentro de un switch.
        public void OperacionesListas()
        {
            Console.WriteLine("Operaciones basicas con listas de enteros");
            List<int> numeros = new List<int>();
            int opcion = -1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Agregar elemento al final");
                Console.WriteLine("2. Insertar elemento en posicion especifica");
                Console.WriteLine("3. Eliminar elemento por valor");
                Console.WriteLine("4. Eliminar elemento por posicion (indice)");
                Console.WriteLine("5. Mostrar y ordenar de menor a mayor");
                Console.WriteLine("6. Mostrar y ordenar de mayor a menor");
                Console.WriteLine("7. Vaciar toda la lista");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion:");

                opcion = int.TryParse(Console.ReadLine() ?? "", out int opt) ? opt : -1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca el numero a agregar:");
                        int nuevo = int.TryParse(Console.ReadLine() ?? "", out int v1) ? v1 : 0;
                        numeros.Add(nuevo);
                        Console.WriteLine("Elemento agregado correctamente");
                        break;

                    case 2:
                        Console.WriteLine($"Introduzca la posicion (0 a {numeros.Count}):");
                        int pos = int.TryParse(Console.ReadLine() ?? "", out int p) ? p : -1;

                        if (pos >= 0 && pos <= numeros.Count)
                        {
                            Console.WriteLine("Introduzca el numero a insertar:");
                            int valinsert = int.TryParse(Console.ReadLine() ?? "", out int v2) ? v2 : 0;
                            numeros.Insert(pos, valinsert);
                            Console.WriteLine("Elemento insertado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Posicion fuera de rango");
                        }
                        break;

                    case 3:
                        if (numeros.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            Console.WriteLine("Introduzca el valor a eliminar:");
                            int valelim = int.TryParse(Console.ReadLine() ?? "", out int v3) ? v3 : 0;
                            bool eliminado = numeros.Remove(valelim);

                            if (eliminado)
                            {
                                Console.WriteLine("Elemento eliminado de la lista");
                            }
                            else
                            {
                                Console.WriteLine("El valor no existe en la lista");
                            }
                        }
                        break;

                    case 4:
                        if (numeros.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            Console.WriteLine($"Introduzca el indice a borrar (0 a {numeros.Count - 1}):");
                            int posborrar = int.TryParse(Console.ReadLine() ?? "", out int pb) ? pb : -1;

                            if (posborrar >= 0 && posborrar < numeros.Count)
                            {
                                numeros.RemoveAt(posborrar);
                                Console.WriteLine("Elemento borrado de esa posicion");
                            }
                            else
                            {
                                Console.WriteLine("Indice fuera de los limites de la lista");
                            }
                        }
                        break;

                    case 5:
                        if (numeros.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            numeros.Sort();
                            Console.WriteLine("Lista ordenada ascendente:");
                            foreach (int item in numeros)
                            {
                                Console.Write($"{item} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        if (numeros.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            numeros.Sort();
                            numeros.Reverse();
                            Console.WriteLine("Lista ordenada descendente:");
                            foreach (int item in numeros)
                            {
                                Console.Write($"{item} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 7:
                        numeros.Clear();
                        Console.WriteLine("Se han eliminado todos los elementos de la lista");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del menu de operaciones");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion != 0);
        }
    }
}