using System;

namespace Escuela
{
    class Programa
    {

        static void Main(string[] args)
        {
            IGestor gestor = new GestorPersonas();

            int opcion = 0;

            while (opcion != 6)
            {

                Console.WriteLine("===== Gestion de Personas | Escuela Santo Domingo =====");
                Console.WriteLine("1. Estudiante");
                Console.WriteLine("2. Profesor");
                Console.WriteLine("3. Administrativo");
                Console.WriteLine("4. Padre");
                Console.WriteLine("5. Mostrar Personas");
                Console.WriteLine("6. Salir");
                Console.WriteLine("========================================");

                Console.Write("Ingrese una opcion: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            gestor.CrearEstudiante();
                            break;
                        case 2:
                            gestor.CrearProfesor();
                            break;
                        case 3:
                            gestor.CrearAdministrativo();
                            break;
                        case 4:
                            gestor.CrearPadre();
                            break;
                        case 5:
                            gestor.MostrarPersonas();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }

                }
            }


        }
    }

    public interface IGestor
    {
        void CrearEstudiante();
        void CrearProfesor();
        void CrearAdministrativo();
        void CrearPadre();
        void MostrarPersonas();
    }
    public class GestorPersonas : IGestor
    {

        private List<Persona> _lista = new List<Persona>();

        private (string nombre, string apellido) PedirNombreYApellido()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();
            return (nombre, apellido);
        }
        public void CrearEstudiante()
        {
            var (nombre, apellido) = PedirNombreYApellido();

            Estudiante estudiante = new Estudiante()
            {
                Apellido = apellido,
                Nombre = nombre
            };

            _lista.Add(estudiante);
            Console.WriteLine("Perfil de alumno creado.");
        }

        public void CrearProfesor()
        {
            var (nombre, apellido) = PedirNombreYApellido();

            Profesor profesor = new Profesor()
            {
                Apellido = apellido,
                Nombre = nombre,
            };
            _lista.Add(profesor);
            Console.WriteLine("Perfil de profesor creado.");
        }

        public void CrearAdministrativo()
        {
            var (nombre, apellido) = PedirNombreYApellido();

            Console.Write("Ingrese su cargo: ");
            string cargo = Console.ReadLine();

            Administrativo administrativo = new Administrativo()
            {
                Apellido = apellido,
                Nombre = nombre,
                Cargo = cargo
            };
            _lista.Add(administrativo);
            Console.WriteLine($"Perfil {cargo} creado");
        }

        public void CrearPadre()
        {
            var (nombre, apellido) = PedirNombreYApellido();

            Padre padre = new Padre()
            {
                Apellido = apellido,
                Nombre = nombre
            };
            _lista.Add(padre);
            Console.WriteLine($"Perfil Padre creado");
        }

        public void MostrarPersonas()
        {
            if (_lista.Count == 0)
            {
                Console.Write("No hay personas registradas.\n");
                Console.ReadKey();
                return;
            }
            foreach (Persona p in _lista)
            {
                Console.WriteLine($"Rol: {p.ObtenerRol()} | Nombre: {p.Nombre} {p.Apellido}");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public abstract string ObtenerRol();
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
        public List<Calificacion> Calificacionesc { get; set; } = new List<Calificacion>();

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
            return "Administrativo";
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

    public class Pago
    {
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Concepto { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }


    public class Padre : Persona
    {
        public List<Estudiante> Hijos { get; set; } = new List<Estudiante>();
        public override string ObtenerRol()
        {
            return "Padre";
        }

    }

    public class Curso
    {
        public int CursoId { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
}
