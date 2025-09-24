public interface IPayable //se establece una interfaz, que funcionara como un contrato
{
    //se establece la parte del contrato que deben cumplir las clases que implementen la interfaz
    decimal CalculatePayment();
}

public abstract class EmployeeBase : IPayable, IReportable //se crea una nueva clase abstracta que implementa la interfaz
{
    public string FullName { get; } //solo lectura
    protected EmployeeBase(string name) => FullName = name; //constructor de la clase
    public abstract decimal CalculatePayment(); //implementa la parte del contrato que debe cumplir
    public abstract decimal TaxRate(); //metodo abstracto para calcular la retencion de impuestos, por defecto es 0

    public string BuildReport()
    {
        return $"{FullName} - Pago: {CalculatePayment():C0} - Retención: {TaxRate():C0}";
    }
}

public class FullTime : EmployeeBase //clase hija de EmployeeBase para crear un tipo de empleado (FullTime/a tiempo completo)
{
    public decimal Monthly { get; } //solo lectura
    public FullTime(string name, decimal monthly) : base(name) => Monthly = monthly; //constructor de la clase hija, añade un parametro (monthly)
    public override decimal CalculatePayment() => Monthly; //se calcula su pago 

    public override decimal TaxRate() => CalculatePayment() * 0.03m;
}


public class Hourly : EmployeeBase, IReportable //clase hija de EmployeeBase, tipo de empleado Hourly
{
    public decimal Rate { get; } //solo lectura
    public int Hours { get; } //solo lectura
    public Hourly(string name, decimal rate, int hours) : base(name) { Rate = rate; Hours = hours; } //constructor clase hija, añade dos parametros (rate y hours)
    public override decimal CalculatePayment() => Rate * Hours; //se calcula su pago

    public override decimal TaxRate() => CalculatePayment() * 0.1m;
    
    public string BuildReport()
    {
        return base.BuildReport() + $" - Horas: {Hours} - Tarifa: {Rate:C0}";
    }
}


// var payroll = new List<IPayable> //se crea una lista con empleados
// {
//     new FullTime("Ana", 4_200_000m), //uno a tiempo completo
//     new Hourly("Luis", 60_000m, 80) //y otro por horas
// };
// public void PrintPayable()
// {
//     foreach (var p in payroll) //por cada uno se imprime su nombre y su pago
//         Console.WriteLine($"{p.GetType().Name} -> Pago: {p.CalculatePayment():C0}");
// }

/* Ejercicio 3
    Crea IReportable con string BuildReport().
    Implementa en FullTime y Hourly.
    Recorre List<IReportable> y muestra reportes.
    Plus: agrega TaxRate y calcula retenciones (sólo en Hourly).
 */

public interface IReportable
{
    public string BuildReport(); 

}
