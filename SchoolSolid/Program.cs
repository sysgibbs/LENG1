using System;
using System.Reflection.PortableExecutable;
using System.Security.Authentication;

namespace Escuela
{
    class Programa
    {
        static List<Persona> ListaPersonas = new List<Persona>();
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("===== Gestion de Personas | Escuela Santo Domingo =====");
                Console.WriteLine("1. Estudiante");
                Console.WriteLine("2. Profesor");
                Console.WriteLine("3. Administrativo");
                Console.WriteLine("4. Mostrar Personas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("========================================");

                Console.Write("Ingrese una opcion: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            CrearEstudiante();
                            break;
                        case 2:
                            CrearProfesor();
                            break;
                        case 3:
                            CrearAdministrativo();
                            break;
                        case 4:
                            MostrarPersonas();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }

                }
            }

            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }



        public static void CrearEstudiante()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            Estudiante estudiante = new Estudiante()
            {
                Apellido = apellido,
                Nombre = nombre
            };
            ListaPersonas.Add(estudiante);
        }

        public static void CrearProfesor()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            Profesor profesor = new Profesor()
            {
                Apellido = apellido,
                Nombre = nombre
            };
            ListaPersonas.Add(profesor);
        }

        public static void CrearAdministrativo()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese su cargo: ");
            string cargo = Console.ReadLine();

            Administrativo administrativo = new Administrativo()
            {
                Apellido = apellido,
                Nombre = nombre,
                Cargo = cargo
            };
            ListaPersonas.Add(administrativo);
        }

        public static void MostrarPersonas()
        {
            foreach (Persona p in ListaPersonas)
            {
                Console.WriteLine(p.Nombre);
                Console.WriteLine(p.Apellido);
                Console.WriteLine(p.ObtenerRol());
            }
        }
    }


    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public virtual string ObtenerRol()
        {
            return "Persona Generica";
        }

    }

    public class Estudiante : Persona
    {
        public List<Padre> Padres { get; set; } = new List<Padre>();
        public List<Calificacion> Calificaciones { get; set; } = new List<Calificacion>();
        public override string ObtenerRol()
        {
            return "Estudiante";
        }
    }

    public class Asignatura
    {
        public string Nombre { get; set; } = string.Empty;
        public Profesor Profesor { get; set; }
        public List<Horario> Horarios { get; set; } = new List<Horario>();
        public List<Calificacion> Calificaciones { get; set; } = new List<Calificacion>();

    }

    public class Profesor : Persona
    {
        public List<Horario> Horarios { get; set; } = new List<Horario>();
        public List<Calificacion> Calificaciones { get; set; } = new List<Calificacion>();

        public override string ObtenerRol()
        {
            return "Profesor";
        }
    }

    public class Calificacion
    {
        public double Nota { get; set; }
        public string Literal { get; set; } = string.Empty;
        public Profesor Profesor { get; set; }
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }

    }

    public class Aula
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Capacidad { get; set; }

    }

    public class Administrativo : Persona
    {
        public string Cargo { get; set; } = string.Empty;
        public override string ObtenerRol()
        {
            return "Administrativos";
        }
    }

    public class Horario
    {
        public string Dia { get; set; } = string.Empty;
        public Asignatura Asignatura { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public Aula Aula { get; set; }

    }

    public class Pagos
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public string Concepto { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }


    public class Padre : Persona
    {
        public List<Estudiante> Hijos = new List<Estudiante>();

    }

    public class Curso
    {
        public int CursoId { get; set; }
        public List<Estudiante> Estudiantes = new List<Estudiante>();
        public List<Asignatura> Asignaturas = new List<Asignatura>();
    }
}
