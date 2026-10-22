using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio24
    {
        // Suma de pares e impares - Para los números del 1 al N (N ingresado por el usuario), calcular
// por separado la suma y la cantidad de números pares e impares.
        public void Suma()
        {
            Console.WriteLine("Suma de numeros de 1 a N");
            Console.WriteLine("Escriba el techo de la suma:");
            int numero = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            if (numero > 0)
            {
                int cnumeropar=0;
                int sumapar=0;
                int cnumeroimpar=0;
                int sumaimpar=0;
                for(int i=1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumapar+=i;
                        cnumeropar++;
                    }
                    else
                    {
                        sumaimpar+=i;
                        cnumeroimpar++;
                    }
                    
                }
            Console.WriteLine($"Resultados para el rango de 1 a {numero}:");
            Console.WriteLine($"Pares: {cnumeropar} numeros | Suma total: {sumapar}");
            Console.WriteLine($"Impares: {cnumeroimpar} numeros | Suma total: {sumaimpar}");
            }
            else
            {
                Console.WriteLine("El numero que introdujo no es valido");
            }
        }
    }
}