using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio35
    {
// 35. Patrones en consola - Menú para generar patrones: triángulo, triángulo invertido, rombo,
// cuadrado hueco y pirámide numérica. El usuario define el tamaño.
// Muestra menu numerico y genera figuras usando ciclos for anidados para espacios y asteriscos.
        public void Patrones()
        {
            Console.WriteLine("Menu de patrones en consola");
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. Triangulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine("5. Piramide numerica");
            Console.WriteLine("Seleccione una opcion:");
            int opcion = int.TryParse(Console.ReadLine(), out int opt) ? opt : 0;

            Console.WriteLine("Introduzca el tamano:");
            int n = int.TryParse(Console.ReadLine(), out int tam) ? tam : 0;

            if (n <= 0)
            {
                Console.WriteLine("El tamano debe ser mayor a cero");
            }
            else
            {
                if (opcion == 1)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else if (opcion == 2)
                {
                    for (int i = n; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else if (opcion == 3)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= (2 * i - 1); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = n - 1; i >= 1; i--)
                    {
                        for (int j = 1; j <= n - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= (2 * i - 1); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else if (opcion == 4)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if (opcion == 5)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write($"{k} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Opcion de menu no valida");
                }
            }
        }
    }
}