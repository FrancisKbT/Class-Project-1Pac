using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio33
    {
// 33. Juego de adivinanza - El programa genera un número aleatorio (1-100). El usuario tiene 7
// intentos con pistas de "mayor" o "menor". Mostrar estadísticas al final.
// Logica: Genera un numero con Random y usa un for de 7 vueltas dando pistas hasta acertar o gastar intentos.
        public void Adivinanza()
        {
            Console.WriteLine("Juego de adivinanza (1 al 100)");
            Console.WriteLine("Tiene un maximo de 7 intentos para adivinar el numero secreto");

            Random random = new Random();
            int secret = random.Next(1, 101);
            int intentosusados = 0;
            bool acertado = false;

            for (int i = 1; i <= 7; i++)
            {
                intentosusados = i;
                Console.WriteLine($"Intento {i}: Introduzca su numero:");
                int intento = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

                if (intento == secret)
                {
                    acertado = true;
                    break;
                }
                else if (intento < secret)
                {
                    Console.WriteLine("Pista: El numero secreto es mayor");
                }
                else
                {
                    Console.WriteLine("Pista: El numero secreto es menor");
                }
            }

            Console.WriteLine("Estadisticas finales:");
            if (acertado == true)
            {
                Console.WriteLine($"Felicidades, adivino el numero en el intento {intentosusados}");
            }
            else
            {
                Console.WriteLine($"Se agotaron los intentos. El numero secreto era: {secret}");
            }
            Console.WriteLine($"Total de intentos realizados: {intentosusados}");
        }
    }
}