public class CalculoIMC : Calculos
{
    double resultado;
    public override double Calculo(double n1, double n2) {
        resultado = n1 / (n2 * n2);
        return resultado;
    }

    public void impresionCalculo() {
        string estado;
        Console.WriteLine($"Su IMC es: {resultado}");
        if (resultado < 18.5)
        {
            estado = "Bajo peso";
        }
        else if (resultado >= 18.5 && resultado < 24.9)
        {
            estado = "Peso normal";
        }
        else if (resultado >= 25 && resultado < 29.9)
        {
            estado = "Sobrepeso";
        }
        else
        {
            estado = "Obesidad";
        }
        Console.WriteLine($"Estado: {estado}");
    }
}