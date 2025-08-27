public class Motocicleta : Vehiculo
{
    public bool Manubrio { get; set; }

    public void Endo()
    {
        Console.WriteLine("Hizo un endo");
    }

    public override string Encender()
    {
        return "Encender con crackn";
    }

    public void VerEncender()
    {
        Console.WriteLine(Encender());
    }
}