/*
!Realice un programa que solicite de dos valores al usuario y luego imprima por pantalla los

resultados de las operaciones:
Suma
Resta
Multiplicacion
Division
Raiz cuadrada de cada valo
*/

using System.Diagnostics.CodeAnalysis;

namespace PrimerEjercicio
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Inserte el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Inserte el signo (+, -, *, /, raiz): ");
            string operacion = Console.ReadLine();

            if (operacion == "+")
            {
                int suma = num1 + num2;
                Console.WriteLine($"La suma de {num1} + {num2} = {suma}");
            }
            else if (operacion == "-")
            {
                int resta = num1 - num2;
                Console.WriteLine($"La resta de {num1} - {num2} = {resta}");
            }
            else if (operacion == "*")
            {
                int multi = num1 * num2;
                Console.WriteLine($"La muliplicacion de {num1} * {num2} = {multi}");
            }
            else if (operacion == "/")
            {
                if (num2 != 0)
                {
                    int division = num1 / num2;
                    Console.WriteLine($"La division de {num1} / {num2} = {division}");
                }
                else
                {
                    Console.WriteLine("No es posible dividir entre 0.");
                }

            }
            else if (operacion == "raiz")
            {
                double raiz1 = Math.Sqrt(num1);
                double raiz2 = Math.Sqrt(num2);
                Console.WriteLine($"La raiz cuadrada de {num1} es {raiz1:F4}.");
                Console.WriteLine($"La raiz cuadrada de {num2} es {raiz2:F4}.");
            }
            else
            {
                Console.WriteLine("Error inserte un signo aritmetico correcto.");
            }

        }
    }
}
