using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio46
    {
// 46. Lista de estudiantes - Mantener lista de nombres de estudiantes. Permitir: agregar sin duplicados,
// buscar por nombre (búsqueda lineal), eliminar un estudiante, mostrar lista ordenada alfabéticamente.
// Logica: Utiliza List<string> validando la no duplicidad con Contains e ignorando diferencias entre mayúsculas y minúsculas.
        public void ListaEstudiantes()
        {
            Console.WriteLine("Control de lista de estudiantes");
            List<string> estudiantes = new List<string>();
            int opcion = -1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Agregar estudiante (sin duplicados)");
                Console.WriteLine("2. Buscar estudiante");
                Console.WriteLine("3. Eliminar estudiante");
                Console.WriteLine("4. Mostrar listado ordenado");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion:");

                opcion = int.TryParse(Console.ReadLine() ?? "", out int opt) ? opt : -1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca el nombre del estudiante:");
                        string nombre = (Console.ReadLine() ?? "").Trim();

                        if (string.IsNullOrEmpty(nombre))
                        {
                            Console.WriteLine("El nombre no puede quedar vacio");
                        }
                        else
                        {
                            bool existe = false;
                            for (int i = 0; i < estudiantes.Count; i++)
                            {
                                if (estudiantes[i].ToLower() == nombre.ToLower())
                                {
                                    existe = true;
                                    break;
                                }
                            }

                            if (existe)
                            {
                                Console.WriteLine("Ese estudiante ya esta registrado en la lista");
                            }
                            else
                            {
                                estudiantes.Add(nombre);
                                Console.WriteLine("Estudiante registrado exitosamente");
                            }
                        }
                        break;

                    case 2:
                        if (estudiantes.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            Console.WriteLine("Introduzca el nombre a buscar:");
                            string buscado = (Console.ReadLine() ?? "").Trim().ToLower();
                            int poshallada = -1;

                            for (int i = 0; i < estudiantes.Count; i++)
                            {
                                if (estudiantes[i].ToLower() == buscado)
                                {
                                    poshallada = i;
                                    break;
                                }
                            }

                            if (poshallada >= 0)
                            {
                                Console.WriteLine($"Estudiante encontrado: {estudiantes[poshallada]} en la posicion {poshallada + 1}");
                            }
                            else
                            {
                                Console.WriteLine("El estudiante no se encuentra en el registro");
                            }
                        }
                        break;

                    case 3:
                        if (estudiantes.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes para eliminar");
                        }
                        else
                        {
                            Console.WriteLine("Introduzca el nombre del estudiante a retirar:");
                            string retirar = (Console.ReadLine() ?? "").Trim().ToLower();
                            int indiceborrar = -1;

                            for (int i = 0; i < estudiantes.Count; i++)
                            {
                                if (estudiantes[i].ToLower() == retirar)
                                {
                                    indiceborrar = i;
                                    break;
                                }
                            }

                            if (indiceborrar >= 0)
                            {
                                estudiantes.RemoveAt(indiceborrar);
                                Console.WriteLine("Estudiante eliminado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No se encontro al estudiante que desea eliminar");
                            }
                        }
                        break;

                    case 4:
                        if (estudiantes.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            estudiantes.Sort();
                            Console.WriteLine("Listado de estudiantes ordenado:");
                            for (int i = 0; i < estudiantes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {estudiantes[i]}");
                            }
                        }
                        break;

                    case 0:
                        Console.WriteLine("Cerrando registro de estudiantes");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 0);
        }
    }
}