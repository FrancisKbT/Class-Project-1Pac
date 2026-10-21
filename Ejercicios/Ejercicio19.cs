using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio19
    {
//         Clasificación de triángulos - Dados tres lados, determinar si forman un triángulo válido y
// clasificarlo (equilátero, isósceles, escaleno) y por sus ángulos (rectángulo, acutángulo,
// obtusángulo).
        public void Clasificacion()
        {
            Console.WriteLine("Clasificacion de triangulos por lados y angulos");
            Console.WriteLine("Ingrese el primer lado:");
            double Lado1 = double.TryParse(Console.ReadLine(), out double nro) ? nro : 0;
            Console.WriteLine("Ingrese el segundo lado:");
            double Lado2 = double.TryParse(Console.ReadLine(), out nro) ? nro : 0;
            Console.WriteLine("Ingrese el tercer lado:");
            double Lado3 = double.TryParse(Console.ReadLine(), out nro) ? nro : 0;
            if( Lado3>0 && Lado2>0 && Lado1 > 0)
            {
                if((Lado1+Lado2)>Lado3 && (Lado1+Lado3)>Lado2 && (Lado2 + Lado3) > Lado1)
                {
                    if(Lado1==Lado2 && Lado3 == Lado1)
                    {
                        Console.WriteLine($"El triangulo con dos iguales {Lado1} es equilatero");
                    }
                    else if(Lado1==Lado2 || Lado2==Lado3 || Lado3 == Lado1)
                    {
                        Console.WriteLine($"El triangulo con lados {Lado1}, {Lado2}, {Lado3} es Isósceles");

                    }
                    else
                    {
                        Console.WriteLine($"El triangulo con lados {Lado1}, {Lado2}, {Lado3} es Escaleno");
                    }
                    if ((Lado3*Lado3)== (Lado2*Lado2)+(Lado1*Lado1) || (Lado2*Lado2)== (Lado3*Lado3)+(Lado1*Lado1) ||(Lado1*Lado1)== (Lado2*Lado2)+(Lado3*Lado3) ) 
                    //esta evaluacion es demasiado larga, pero la hice asi para no agregar nuevas variables para el calculo
                    {
                        Console.WriteLine($"El triangulo que introdujo es un triangulo Rectángulo");
                    }
                    else if ((Lado3*Lado3)< (Lado2 * Lado2) + (Lado1 * Lado1) || (Lado2*Lado2)< (Lado3 * Lado3) + (Lado1 * Lado1) || (Lado2*Lado2)< (Lado3* Lado3) + (Lado1 * Lado1))
                    {
                        Console.WriteLine($"El triangulo que introdujo es un triangulo Acutángulo");
                    }
                    else
                    {
                        Console.WriteLine($"El triangulo que introdujo es un triangulo Obtusángulo");

                    }

                }
                else Console.WriteLine("Los datos introducidos son invalidos");


            }
            else Console.WriteLine("Los datos introducidos son invalidos");

            
        }

    }
}