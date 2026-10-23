# Class-Project-1Pac
# Class-Project-1Pac

Proyecto con la solucion a los 50 ejercicios de la guia de clase desarrollados en C#.

## Decisiones tecnicas
* Se utilizo int.TryParse y decimal.TryParse junto con operadores ternarios en lugar de int.Parse o Convert.ToInt32 para evitar que el programa se caiga si el usuario ingresa letras o presiona Enter sin escribir nada.
* Las lecturas de texto incluyen el operador de coalescencia nula (Console.ReadLine() ?? "") para prevenir advertencias de referencias nulas en el compilador.
* Para el manejo de dinero y subtotales se uso el tipo decimal por precision numerica en lugar de float o double.
* Cada ejercicio esta separado en su propia clase con un metodo publico para mantener el codigo ordenado y facilitar su revision.

## Como ejecutarlo
1. Abrir la carpeta del proyecto en una terminal o en Visual Studio Code.
2. En el archivo Program.cs descomentar la linea del ejercicio que se desea probar y comentar el que estaba activo.
3. Compilar y correr el proyecto con el comando: dotnet run