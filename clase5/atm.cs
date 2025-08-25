public class atm
{
    private int saldo = 500000;
    private int cantidadRetiro;

    public void imprimirSaldo()
    {
        Console.WriteLine($"Su saldo es: {saldo}");
    }

    public void retirar()
    {
        Console.Write("Ingrese el monto a retirar: ");
        cantidadRetiro = int.Parse(Console.ReadLine());
        if (cantidadRetiro <= saldo)
        {
            saldo = saldo - cantidadRetiro;
            Console.WriteLine($"Retiro exitoso. Saldo actualizado: ${saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para el retiro.");
        }
    }

    public void salir()
    {
        Console.WriteLine("Saliendo...");
    }
}