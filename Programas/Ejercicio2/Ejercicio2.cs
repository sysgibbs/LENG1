/*
!El colegio “Dios es bueno” necesita obtener la lista de las calificaciones de los estudiantes.
? Para esto deberá escribir un programa c# que obtenga:
Nombres
Calificaciones
*/
using System;
using System.Diagnostics.CodeAnalysis;


namespace EjercicioDos
{

    class EjercicioDos
    {
        public static void Main(string[] args)
        {

            string name;

            Console.Write("Inserte su nombre: ");

            name = Console.ReadLine();

            Console.WriteLine($"Your name is {name.TO()}.");

            Console.ReadKey();
        }
    }
}
