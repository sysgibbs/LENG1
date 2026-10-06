/*
!Modifique el ejercicio #2:

- El Reporte debe aparecer ordenado por el primer Apellido
- Al final del reporte debe mostrar los totales de:
    - Estudiantes en A:
    - Estudiantes en B:
    - Estudiantes en C:
    - Estudiantes en Reprobado
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

            int totalA = 0;
            int totalB = 0;
            int totalC = 0;
            int totalReprobado = 0;

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
                    notas[i] = int.Parse(Console.ReadLine(), out notas[i]);

                    while (notas[i] < 0 || notas[i] > 100)
                    {
                        Console.WriteLine("Error nota incorrecta. Intente nuevamente.");
                        notas[i] = int.Parse(Console.ReadLine(), out notas[i]);
                    }

                    suma += notas[i];
                }

                double promedio = (double)suma / 4;
                string literal = "";

                if (promedio >= 90)
                {
                    literal = "A";
                    totalA++;
                }
                else if (promedio >= 80)
                {
                    literal = "B";
                    totalB++;
                }
                else if (promedio >= 70)
                {
                    literal = "C";
                    totalC++;
                }
                else
                {
                    literal = "F";
                    totalReprobado++;
                }


                string filaAlumno = $"{nombre} | {apellido} | {notas[0]} | {notas[1]} | {notas[2]} | {notas[3]} | {promedio} | {literal}";
                listaEstudiantes.Add(filaAlumno);

                Console.Write("Desea ingresar otro estudiante? (s/n): ");
                continuar = Console.ReadLine();
                Console.WriteLine();
            }


            listaEstudiantes.Sort((a, b) =>
            {
                string apellidoA = a.Split('|')[1].Trim();
                string apellidoB = b.Split('|')[1].Trim();

                return apellidoA.CompareTo(apellidoB);
            });


            Console.WriteLine("\nColegio Dios es bueno.");
            Console.WriteLine("Calificaciones del cuatrimestre");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Nombre | Apellido | Nota1 | Nota2 | Nota3 | Nota4 | Promedio | Literal");
            Console.WriteLine("===========================================================");


            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                Console.WriteLine(listaEstudiantes[i]);
            }


            Console.WriteLine("===========================================================");
            Console.WriteLine("Totales:");
            Console.WriteLine("Estudiantes en A: " + totalA);
            Console.WriteLine("Estudiantes en B: " + totalB);
            Console.WriteLine("Estudiantes en C: " + totalC);
            Console.WriteLine("Estudiantes en Reprobado: " + totalReprobado);
        }
    }
}
