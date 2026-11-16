using System;

namespace EjemploPdf;

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria miCuenta = new CuentaBancaria();
        miCuenta.Saldo = -1500;
        // Console.WriteLine($"Saldo actual: {miCuenta.Saldo}");

        Calculadora calculadora = new Calculadora();

        int resultado1 = calculadora.Sumar(3, 3);
        // Console.WriteLine(resultado1);

        int resultado2 = calculadora.Sumar(3, 3, 3);
        // Console.WriteLine(resultado2);

    }


}
public class CuentaBancaria
{
    private decimal _saldo;

    public decimal Saldo
    {
        get => _saldo;

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: El saldo no puede ser negativo.");
            }
            else
            {
                _saldo = value;
            }

        }
    }

}

public class Producto
{
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }

    public Producto()
    {
        Nombre = "Sin nombre";
        Precio = 0;
    }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

public class Calculadora
{
    public int Sumar(int a, int b) => a + b;

    public int Sumar(int a, int b, int c) => a + b + c;

}

public class Vehiculo
{
    protected string _marca;

    public virtual void Arrancar()
    {
        Console.WriteLine("El vehiculo esta arrancadno de forma automatica.");

    }

}

public class Carro : Vehiculo
{
    public Carro(string marca)
    {
        _marca = marca;
    }

    public override void Arrancar()
    {
        Console.WriteLine($"El carro {_marca} arraca.");
    }
}
