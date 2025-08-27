public abstract class Vehiculo //clase padre
{
    //atributos comunes
    public string Marca { get; set; }
    public string Linea { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }

    public abstract string Encender();

    //metodos comunes
    // public void Encender() {
    //     Console.WriteLine("Esta encendido");
    // }

    public void Arrancar() {
        Console.WriteLine("Esta arrancando");
    }

    public void Acelerar() {
        Console.WriteLine("Esta en movimiento");
    }

    public void Frenar() {
        Console.WriteLine("Esta arrancando");
    }
}