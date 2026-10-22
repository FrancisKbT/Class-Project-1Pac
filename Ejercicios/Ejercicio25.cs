using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio25
    {
//  Promedio con centinela - Leer números hasta que el usuario ingrese -1. Calcular y mostrar el
// promedio, el valor máximo y el mínimo de los valores ingresados (sin contar el -1).
        public void Promedio()
        {
            Console.WriteLine("Promedio de lecturas");
            Console.WriteLine("para finalizar el programa, introduzca -1");
            int numero=0;
            int suma=0;
            int nro=0;
            int i=0;
            int mayor=0;
            int menor=0;
            while (numero!=-1)
            {
                
                Console.WriteLine($"introduzca el dato {i+1}");
                numero= int.TryParse(Console.ReadLine(), out nro) ? nro:0; // no lo voy a validar, en este caso si podria meter datos negativos
                if(numero == -1)
                {
                    break;
                }
                i++;
                suma+=numero;
                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > mayor)
                 {
                        mayor = numero;
                 }
                    else if (numero < menor)
                    {
                        menor = numero;
                    }
                }
                
                
            }
            if (i == 0)
            {
                Console.WriteLine("No hay datos que mostrar.");
            }
            else
            {
                Console.WriteLine("Reporte:");
                Console.WriteLine($"El numero menor fue{menor}");
                Console.WriteLine($"El numero mayor fue {mayor}");
                Console.WriteLine($"El promedio fue de {(double)suma/i}");
            }


        }
    }
}