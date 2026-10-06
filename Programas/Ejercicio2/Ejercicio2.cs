/*
!El colegio “Dios es bueno” necesita obtener la lista de las calificaciones de los estudiantes.
Para esto deberá escribir un programa c# que obtenga los nombres de los estudiantes y las
calificaciones
*/

using System;
using System.Collections.Generic;

namespace Programa
{
    class EjercicioDos
    {
        public static void Main(string[] args)
        {

            List<string> listaEstudiantes = new List<string>();

            string continuar = "s";

            while (continuar.ToLower() == "s")
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del estudiante: ");
                string apellido = Console.ReadLine();


                int[] notas = new int[4];
                int suma = 0;

                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Ingrese la nota {i + 1} (0-100): ");
                    notas[i] = int.Parse(Console.ReadLine());

                    while (notas[i] < 0 || notas[i] > 100)
                    {
                        Console.WriteLine("Error nota incorrecta. Intente nuevamente.");
                        notas[i] = int.Parse(Console.ReadLine());
                    }

                    suma += notas[i];
                }

                double promedio = (double)suma / 4;
                string literal = "";

                if (promedio >= 90)
                {
                    literal = "A";
                }
                else if (promedio >= 80)
                {
                    literal = "B";
                }
                else if (promedio >= 70)
                {
                    literal = "C";
                }
                else if (promedio >= 60)
                {
                    literal = "D";
                }
                else
                {
                    literal = "F";
                }


                string filaAlumno = $"{nombre} | {apellido} |  {notas[0]} | {notas[1]} | {notas[2]} | {notas[3]} | {promedio} | {literal}";
                listaEstudiantes.Add(filaAlumno);

                Console.Write("Desea ingresar otro estudiante? (s/n): ");
                continuar = Console.ReadLine();
                Console.WriteLine();
            }


            Console.WriteLine("\nColegio Dios es bueno.");
            Console.WriteLine("Calificaciones del cuatrimestre");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Nombre | Apellido Nota1 | Nota2 | Nota3 | Nota4 | Promedio | Literal");
            Console.WriteLine("===========================================================");


            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                Console.WriteLine(listaEstudiantes[i]);
            }
        }
    }
}
