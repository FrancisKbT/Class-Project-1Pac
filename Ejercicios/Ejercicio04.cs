using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio04
    {
//         Área y perímetro - Menú para calcular área y perímetro de: círculo, triángulo, rectángulo y
// trapecio. Validar que los valores ingresados sean positivos.
// en este ejercicio voy a usar switch para la evaluacion del menu, no uso un ciclo for para la repeticion, lo dejo para el apartado de ciclos/bucles
        public void Calcular()
        {
            Console.WriteLine("Menú de cálculo de área y perímetro");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Trapecio");
            Console.Write("Seleccione una opción: ");
            int opcion = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Calculo de area y perimetro de un circulo");
                    Console.WriteLine("Introduzca el Radio:");
                    decimal Radio = decimal.TryParse(Console.ReadLine(), out decimal p) ? p : 0;
                    if (Radio > 0)
                    {
                        Console.WriteLine($"El Area del circulo es de {3.141592m * (Radio * Radio)}");
                        Console.WriteLine($"El Perimetro del circulo es de {2 * Radio * 3.141592m}");
                    }
                    else
                    {
                        Console.WriteLine("El valor que introdujo es invalido");
                    }
                    break;

                case 2:
                    Console.WriteLine("Calculo de area y perimetro de un Rectangulo");
                    Console.WriteLine("Introduzca la base:");
                    decimal Base = decimal.TryParse(Console.ReadLine(), out decimal p2) ? p2 : 0;
                    Console.WriteLine("Introduzca la Altura:");
                    decimal Altura = decimal.TryParse(Console.ReadLine(), out p2) ? p2 : 0;
                    if (Base > 0 && Altura > 0)
                    {
                        Console.WriteLine($"El area del rectangulo es :{Base * Altura}");
                        Console.WriteLine($"El Perimetro del rectangulo es :{2 * (Base + Altura)}");
                    }
                    else
                    {
                        Console.WriteLine("El valor que introdujo es invalido");
                    }
                    break;

                case 3:
                    Console.WriteLine("Calculo de area y perimetro de un Triangulo");
                    Console.WriteLine("Introduzca la base:");
                    decimal BaseT = decimal.TryParse(Console.ReadLine(), out decimal p3) ? p3 : 0;

                    Console.WriteLine("Introduzca la Altura:");
                    decimal AlturaT = decimal.TryParse(Console.ReadLine(), out p3) ? p3 : 0;

                    Console.WriteLine("Introduzca el lado 1 :");
                    decimal l1 = decimal.TryParse(Console.ReadLine(), out p3) ? p3 : 0;

                    Console.WriteLine("Introduzca el lado 2 :");
                    decimal l2 = decimal.TryParse(Console.ReadLine(), out p3) ? p3 : 0;

                    Console.WriteLine("Introduzca el lado 3 :");
                    decimal l3 = decimal.TryParse(Console.ReadLine(), out p3) ? p3 : 0;

                    if (BaseT > 0 && AlturaT > 0 && l1 > 0 && l2 > 0 && l3 > 0)
                    {
                        Console.WriteLine($"El area del Triangulo es :{(BaseT * AlturaT) / 2}");
                        Console.WriteLine($"El Perimetro del Triangulo es :{l1 + l2 + l3}");
                    }
                    else
                    {
                        Console.WriteLine("El valor que introdujo es invalido");
                    }
                    break;

                case 4:
                    Console.WriteLine("Calculo de area y perimetro de un Trapecio");
                    Console.WriteLine("Introduzca la base mayor:");
                    decimal BaseMay = decimal.TryParse(Console.ReadLine(), out decimal p4) ? p4 : 0;

                    Console.WriteLine("Introduzca la Base Menor:");
                    decimal BaseMen = decimal.TryParse(Console.ReadLine(), out p4) ? p4 : 0;

                    Console.WriteLine("Introduzca la altura:");
                    decimal altura = decimal.TryParse(Console.ReadLine(), out p4) ? p4 : 0;

                    Console.WriteLine("Introduzca el lado 1 :");
                    decimal lado1 = decimal.TryParse(Console.ReadLine(), out p4) ? p4 : 0;

                    Console.WriteLine("Introduzca el lado 2 :");
                    decimal lado2 = decimal.TryParse(Console.ReadLine(), out p4) ? p4 : 0;

                    if (BaseMay > 0 && BaseMen > 0 && altura > 0 && lado1 > 0 && lado2 > 0)
                    {
                        Console.WriteLine($"El area del Trapecio es :{((BaseMay + BaseMen) * altura) / 2}");
                        Console.WriteLine($"El Perimetro del Trapecio es :{lado1 + lado2 + BaseMay + BaseMen}");
                    }
                    else
                    {
                        Console.WriteLine("El valor que introdujo es invalido");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}