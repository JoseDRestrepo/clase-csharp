// Violación común: servicio mezcla cálculo + consola.
// Refactor: separar responsabilidades.
public interface IPaymentCalculator { decimal Calc(IPayable e); } //se crea una interfaz, en la parte de su contrato el decimal Calc tiene como parametro un IPayable

public class DefaultPaymentCalculator : IPaymentCalculator //se crea uan clase que implementa la interfaz
{
    public decimal Calc(IPayable e) => e.CalculatePayment(); //simplemente llama a la funcion CalculatePayement de IPayable.cs
}

public interface IOutput { void WriteLine(string text); } //otra interfaz, el contrato es un WriteLine
public class ConsoleOutput : IOutput { public void WriteLine(string t) => Console.WriteLine(t); } //clase que implementa la interfaz IOutput

public class PayrollService 
{
    private readonly IPaymentCalculator _calc; //crea un IPayementCalculator que luego tendra su valor lmacenado
    private readonly IOutput _out; //crea un IOutput que luego tendra su valor almacenado

    public PayrollService(IPaymentCalculator calc, IOutput output) //constructor de la clase
    {
        //almacena los valores
        _calc = calc; _out = output;
    }

    //crea un metodo para imprimir el nomrbe del empleado y el calculo del pago por cada empleado en la Lista 
    public void Run(IEnumerable<IPayable> items)
    {
        foreach (var it in items)
            _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
    }
}

/* Ejercicio 4
    Implementa FileOutput : IOutput que escriba a un .txt.
    Crea OvertimeCalculator : IPaymentCalculator que agregue horas extra a Hourly.
    Inyecta ambas en PayrollService y ejecuta.
 */

class FileOutput : IOutput
{
    private readonly string _filePath;
    public FileOutput(string filePath) => _filePath = filePath;
    public void WriteLine(string text)
    {
        using var writer = new StreamWriter(_filePath, append: true);
        writer.WriteLine(text);
    }
}

class OvertimeCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e)
    {
        if (e is Hourly h && h.Hours > 160)
        {
            var overtimeHours = h.Hours - 160;
            var overtimePay = overtimeHours * h.Rate * 1.5m;
            return h.CalculatePayment() + overtimePay;
        }
        return e.CalculatePayment();
    }
}