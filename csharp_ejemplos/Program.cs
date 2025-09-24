// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World! Ingenieria inversa");
partial class Program
{
    static void Main(string[] args)
    {
        var laptop = new Product(1, "Laptop", 10, 2500m);
        var mouse = new Product(2, "Mouse", 50);

        Console.WriteLine($"Producto 1: {laptop.Id}, {laptop.Name}, {laptop.Stock}, {laptop.Price:C0}");
        Console.WriteLine($"Producto 2: {mouse.Id}, {mouse.Name}, {mouse.Stock}, {mouse.Price:C0}");

        var payroll = new List<IReportable> //se crea una lista con empleados
        {
            new FullTime("Ana", 4_200_000m), //uno a tiempo completo
            new Hourly("Luis", 60_000m, 80) //y otro por horas
        };
        foreach (var p in payroll)
        { //por cada uno se imprime su nombre y su pago
            Console.WriteLine(p.BuildReport());
        }

        var empleados = new List<IPayable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 80),
            new Hourly("Jorge", 50_000m, 170)
        };

        var FileOutput = new FileOutput("pagos.txt");
        var overtime = new OvertimeCalculator();

        var Payroll = new PayrollService(overtime, FileOutput);

        Payroll.Run(empleados);


        var persona = new Person("Ana Gomez");
        var empleadoFT = new EmployeeFullTime("Luis Perez", 2_500_000m);
        var manager = new Manager("Jorge Lopez", 5_000_000m, 10);

        Console.WriteLine(persona.Describe());
        Console.WriteLine(empleadoFT.Describe());
        Console.WriteLine(manager.Describe());
    }
}