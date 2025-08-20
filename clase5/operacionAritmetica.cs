public class operacionAritmetica
{
    //propiedades
    //sintaxis
    //modificador de acceso, tipo dato, nombre, propiedades get y set
    //get: asignar datos
    //set: recibir datos
    public int numero1 { get; set; }
    public int numero2 { get; set; }


    //metodos
    //sintaxis
    //modificador de acceso, tipo de retorno, nombre, parametros

    // public int sumar()
    // {
    //     return numero1 + numero2;
    // }

    // public void Sumar()
    // {
    //     int resultado = numero1 + numero2;
    //     Console.WriteLine($"La suma es {resultado}");
    // }

    public void imprimirSumar()
    {
        int resultadoSuma = Sumar(numero1, numero2);
        Console.WriteLine($"El resultado es {resultadoSuma}");
    }

    public int Sumar( int n1, int n2 )
    {
        int resultado = n1 + n2;
        return resultado;
    }
}