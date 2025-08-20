public class conversionMonedas
{
    public double COP { get; set; }
    private double tarifaUSD = 0.00024;
    private double tarifaEUR = 0.00021;
    private double tarifaGBP = 0.00018;


    public double convertirMoneda(double cop, double tarifa)
    {
        double conversion = cop * tarifa;
        return conversion;
    }
    public void imprimirDolar()
    {
        double resultadoDolar = convertirMoneda(COP, tarifaUSD);
        Console.WriteLine($"En dolares: {resultadoDolar:F2}");
    }
    public void imprimirEuros()
    {
        double resultadoEuros = convertirMoneda(COP, tarifaEUR);
        Console.WriteLine($"En euros: {resultadoEuros:F2}");
    }
    public void imprimirLibras()
    {
        double resutladoLibras = convertirMoneda(COP, tarifaGBP);
        Console.WriteLine($"En libras esterlinas: {resutladoLibras:F2}");
    }
}