using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio36
    {
//  36. Calculadora con menú - Calculadora que opera hasta que el usuario elija salir. Incluir
// operaciones básicas, potencia, raíz cuadrada y porcentaje. Mantener el último resultado para
// operaciones encadenadas.
// Bucle while con acumulador donde cada operacion toma el ultimo resultado o pide valor inicial.
        public void Calculadora()
        {
            Console.WriteLine("Calculadora con operaciones encadenadas");
            double acumulador = 0;
            bool primeruso = true;
            bool continuar = true;

            while (continuar)
            {
                if (primeruso)
                {
                    Console.WriteLine("Introduzca el numero inicial:");
                    acumulador = double.TryParse(Console.ReadLine(), out double ini) ? ini : 0;
                    primeruso = false;
                }

                Console.WriteLine($"Valor actual en memoria: {acumulador}");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Limpiar memoria a cero");
                Console.WriteLine("9. Salir");
                Console.WriteLine("Seleccione una operacion:");
                int opcion = int.TryParse(Console.ReadLine(), out int opt) ? opt : 0;

                if (opcion == 9)
                {
                    Console.WriteLine("Saliendo de la calculadora");
                    continuar = false;
                }
                else if (opcion == 8)
                {
                    acumulador = 0;
                    primeruso = true;
                    Console.WriteLine("Memoria reiniciada");
                }
                else if (opcion >= 1 && opcion <= 5 || opcion == 7)
                {
                    Console.WriteLine("Introduzca el segundo valor:");
                    double valor = double.TryParse(Console.ReadLine(), out double val) ? val : 0;

                    if (opcion == 1)
                    {
                        acumulador = acumulador + valor;
                    }
                    else if (opcion == 2)
                    {
                        acumulador = acumulador - valor;
                    }
                    else if (opcion == 3)
                    {
                        acumulador = acumulador * valor;
                    }
                    else if (opcion == 4)
                    {
                        if (valor == 0)
                        {
                            Console.WriteLine("Error: no es posible dividir entre cero");
                        }
                        else
                        {
                            acumulador = acumulador / valor;
                        }
                    }
                    else if (opcion == 5)
                    {
                        double basepot = acumulador;
                        int exppot = (int)valor;
                        double res = 1;
                        int exppositivo = exppot < 0 ? exppot * -1 : exppot;

                        for (int i = 1; i <= exppositivo; i++)
                        {
                            res *= basepot;
                        }

                        if (exppot < 0)
                        {
                            acumulador = 1.0 / res;
                        }
                        else
                        {
                            acumulador = res;
                        }
                    }
                    else if (opcion == 7)
                    {
                        acumulador = (acumulador * valor) / 100.0;
                    }

                    Console.WriteLine($"Resultado actual: {acumulador}");
                }
                else if (opcion == 6)
                {
                    if (acumulador < 0)
                    {
                        Console.WriteLine("Error: no existe raiz cuadrada de un numero negativo");
                    }
                    else
                    {
                        acumulador = Math.Sqrt(acumulador);
                        Console.WriteLine($"Resultado actual: {acumulador}");
                    }
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
    }
}