public class Taxi : Vehiculo
{
    public int Banderazo { get; set; }
    public string Finta { get; set; }

    public int Taximetro(int Banderazo)
    {
        int result = 0;
        int countKm = 0;
        result = Banderazo + countKm;
        return result;
    }

    public override string Encender()
    {
        return "Encender con llave";
    }
    
    public void VerEncender()
    {
        Console.WriteLine(Encender());
    }
}