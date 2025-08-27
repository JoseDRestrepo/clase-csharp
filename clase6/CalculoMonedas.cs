public class CalculoMonedas : Calculos {
    double resultado;
    public override double Calculo(double n1, double n2) {
        resultado = n1 * n2;
        return resultado;
    }

    public void impresionConversion() {
        Console.WriteLine($"El resultado de la conversion es: {resultado}");
    }
}