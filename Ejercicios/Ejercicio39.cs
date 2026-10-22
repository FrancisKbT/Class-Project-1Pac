using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio39
    {
// 39. Estadísticas de calificaciones - Ingresar N calificaciones en un arreglo. Calcular: promedio,
// máxima, mínima, cantidad de aprobados/reprobados y desviación estándar.
// Logica: Almacena notas doubles, calcula estadisticas basicas y luego las diferencias al cuadrado para desviacion.
        public void EstadisticasNotas()
        {
            Console.WriteLine("Estadisticas de calificaciones");
            Console.WriteLine("Cuantas calificaciones desea registrar?");
            int n = int.TryParse(Console.ReadLine(), out int cantidad) ? cantidad : 0;

            if (n <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero");
            }
            else
            {
                double[] notas = new double[n];
                double suma = 0;
                int aprobados = 0;
                int reprobados = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduzca la calificacion {i + 1} (0 a 100):");
                    notas[i] = double.TryParse(Console.ReadLine(), out double calif) ? calif : 0;
                    suma += notas[i];

                    if (notas[i] >= 65)
                    {
                        aprobados++;
                    }
                    else
                    {
                        reprobados++;
                    }
                }

                double promedio = suma / n;
                double maxima = notas[0];
                double minima = notas[0];

                for (int i = 1; i < n; i++)
                {
                    if (notas[i] > maxima)
                    {
                        maxima = notas[i];
                    }
                    if (notas[i] < minima)
                    {
                        minima = notas[i];
                    }
                }

                // Calculo de la desviacion estandar
                double sumacuadrados = 0;
                for (int i = 0; i < n; i++)
                {
                    double diferencia = notas[i] - promedio;
                    sumacuadrados += diferencia * diferencia;
                }
                double desviacion = Math.Sqrt(sumacuadrados / n);

                Console.WriteLine("Reporte de estadisticas:");
                Console.WriteLine($"Promedio general: {promedio}");
                Console.WriteLine($"Calificacion maxima: {maxima}");
                Console.WriteLine($"Calificacion minima: {minima}");
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}");
                Console.WriteLine($"Desviacion estandar: {desviacion}");
            }
        }
    }
}