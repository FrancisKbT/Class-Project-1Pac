using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio03
    {
        // Intercambio de valores - Declarar dos variables con valores iniciales, intercambiar sus valores usando una variable temporal y mostrar el antes y el después. Reto adicional: hacerlo sin variable temporal, usando solo operaciones aritméticas.
        public void Intercambio()
        {
            int N1= 80;
            int N2= 20;
            Console.WriteLine("Intercambio de variables");
            Console.WriteLine($"Primer valor: {N1}, Segundo valor: {N2}");
            int Temporal= N1;
            N1=N2;
            N2=Temporal;
            Console.WriteLine($"Procesando Intercambio...");
            Console.WriteLine($"Primer valor: {N1}, Segundo valor: {N2}");
        }
  

    public void IntercambioNoTemporal()
        {
            int N1= 80;
            int N2= 20;

            Console.WriteLine("Intercambio de variables");
            Console.WriteLine($"Primer valor: {N1}, Segundo valor: {N2}");
            N1= N1+N2;
            N2= N1-N2;
        
            Console.WriteLine($"Procesando Intercambio...");
            Console.WriteLine($"Primer valor: {N1}, Segundo valor: {N2}");
        }
     }
}
