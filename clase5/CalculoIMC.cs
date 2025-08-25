public class CalculoIMC
{
    public double peso { get; set; }
    public double estatura { get; set; }

    public double calcularIMC()
    {
        double imc = peso / (estatura * estatura);
        return imc;
    }

    public void imprimirIMC()
    {
        double resultadoIMC = calcularIMC();
        Console.WriteLine($"Su IMC es: {resultadoIMC:F2}");
        if (resultadoIMC < 18.5)
        {
            Console.WriteLine("Estado: Bajo peso");
        }
        else if (resultadoIMC >= 18.5 && resultadoIMC < 24.9)
        {
            Console.WriteLine("Estado: Peso normal");
        }
        else if (resultadoIMC >= 25 && resultadoIMC < 29.9)
        {
            Console.WriteLine("Estado: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Estado: Obesidad");
        }
    }
}