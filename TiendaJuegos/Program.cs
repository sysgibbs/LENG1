using System;
namespace Juegos;

class Programa
{
    static void Main(string[] args)
    {
        // llamamos a la clase Billetera creando un objeto para que funcione en el Main
        Billetera miBilletera = new Billetera();

        // Se ingresa el saldo disponible para la compra
        Console.Write("Ingrese su saldo: ");
        // Se usa la clase miBilletera con su atributo Dinero para que se guarde
        miBilletera.Dinero = decimal.Parse(Console.ReadLine());


        // Creamos una lista para almacenar el catálogo y la llenamos con los juegos disponibles
        List<Videojuego> catalogo = new List<Videojuego>();
        catalogo.Add(new Videojuego("Dark souls 3", 85));
        catalogo.Add(new Videojuego("Elden Ring", 100));
        catalogo.Add(new Videojuego("Sekiro", 60));
        catalogo.Add(new Videojuego("Lies of P", 90));
        catalogo.Add(new Videojuego("Bloodborne", 35));

        int opcion = 0;

        do
        {
            Console.WriteLine("=== Souls Born Store ===");
            Console.WriteLine($"Saldo actual: ${miBilletera.Dinero:N0}");
            Console.WriteLine("1. Comprar un juego");
            Console.WriteLine("2. Ver total de compras");
            Console.WriteLine("3. Codigo de descuento");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese una opcion: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n=== Catalogo ====");

                        // for loop para mostrar el catalogo
                        for (int i = 0; i < catalogo.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {catalogo[i].Nombre} ${catalogo[i].Precio:N0}");
                        }

                        Console.Write("Elija el juego (1-5): ");
                        int juegoElegido = int.Parse(Console.ReadLine());

                        if (juegoElegido < 1 || juegoElegido > catalogo.Count)
                        {
                            Console.WriteLine("Error juego invalido");
                            break;
                        }
                        // Se obtiene el juego que el usuario selecciono y se le resta 1 por su indice 0
                        Videojuego juegoSeleccionado = catalogo[juegoElegido - 1];

                        Console.Write("Formato (1. Digital | 2. Fisico): ");
                        int formato = int.Parse(Console.ReadLine());


                        if (formato == 1)
                        {
                            // Aqui se crea el objeto de juego digital
                            JuegoDigital digital = new JuegoDigital(juegoSeleccionado.Nombre, juegoSeleccionado.Precio);

                            // Si el dinero disponible es mayor o igual se le resta
                            if (miBilletera.Dinero >= juegoSeleccionado.Precio)
                            {
                                miBilletera.Dinero -= digital.Precio;

                                // Aqui se llama al metodo para sumar al registro de ventas
                                RegistroVentas.RegistrarVenta();

                                //! POLIMORFISMO
                                // Se usa obtenerFormato() para mostrar el formato
                                Console.WriteLine($"Usted ha comprado {digital.Nombre} en formato {digital.ObtenerFormato()} por ${digital.Precio:N0}.");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                            }

                        }
                        else if (formato == 2)
                        {
                            JuegoFisico fisico = new JuegoFisico(juegoSeleccionado.Nombre, juegoSeleccionado.Precio);

                            if (miBilletera.Dinero >= juegoSeleccionado.Precio)
                            {
                                miBilletera.Dinero -= fisico.Precio;

                                RegistroVentas.RegistrarVenta();

                                Console.WriteLine($"Usted ha comprado {fisico.Nombre} en formato {fisico.ObtenerFormato()} por ${fisico.Precio:N0}.");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error formato invalido");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Total de compras {RegistroVentas.TotalVentas}");
                        break;

                    case 3:
                        Console.WriteLine("\n=== Catalogo ====");
                        for (int i = 0; i < catalogo.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {catalogo[i].Nombre} ${catalogo[i].Precio:N0}");
                        }

                        Console.Write("Elija el juego (1-5): ");
                        juegoElegido = int.Parse(Console.ReadLine());

                        if (juegoElegido < 1 || juegoElegido > catalogo.Count)
                        {
                            Console.WriteLine("Error juego invalido");
                            break;
                        }

                        Console.Write("Elija el descuento a aplicar: ");
                        int descuento = int.Parse(Console.ReadLine());


                        juegoSeleccionado = catalogo[juegoElegido - 1];

                        decimal precioConDescuento = juegoSeleccionado.CalcularPrecio(descuento);

                        Console.WriteLine($"El juego {juegoSeleccionado.Nombre} tiene un precio original de ${juegoSeleccionado.Precio:N0}.");

                        Console.WriteLine($"Con un descuento de ${descuento}, el precio final es: ${precioConDescuento:N0}.");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                }

            }
        } while (opcion != 4);
    }
}

public class Billetera
{
    private decimal _dinero;

    public decimal Dinero
    {
        get => _dinero;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: no hay suficiente saldo.");
            }
            else
            {
                _dinero = value;
            }
        }
    }
}

public class Videojuego
{
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }

    public Videojuego()
    {
        Nombre = "Juego sin nombre";
        Precio = 0;
    }
    public Videojuego(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public decimal CalcularPrecio() => Precio;
    public decimal CalcularPrecio(decimal descuento) => Precio - descuento;
    public virtual string ObtenerFormato() => "Formato generico";

}


//! HERENCIA
// Hereda de Videjuego.
public class JuegoFisico : Videojuego
{

    // El cuerpo está vacío porque el constructor base (:)
    // se encarga de asignar Nombre y Precio.
    public JuegoFisico(string nombre, decimal precio) : base(nombre, precio)
    { }

    //! POLIMORFISMO
    // Sobrescribe el método virtual del padre para devolver "Fisico"
    public override string ObtenerFormato() => "Fisico";
}


// Hace lo mismo que JuegoFisico
public class JuegoDigital : Videojuego
{
    public JuegoDigital(string nombre, decimal precio) : base(nombre, precio)
    { }
    public override string ObtenerFormato() => "Digital";
}



public static class RegistroVentas
{
    //! ENCAPSULAMIENTO
    // Se declara privado para proteger el contador de modificaciones externas.
    private static int _totalVentas = 0;

    // La propiedad pública solo tiene get,
    // permitiendo leer el valor pero no asignarlo directamente.
    public static int TotalVentas
    {
        get => _totalVentas;
    }

    // Usamos un método estático para no tener que
    //  instanciar la clase con 'new' cada vez.
    public static void RegistrarVenta()
    {
        _totalVentas++;
    }
}
