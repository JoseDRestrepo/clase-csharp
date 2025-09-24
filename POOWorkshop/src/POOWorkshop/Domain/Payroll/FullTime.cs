namespace POOWorkshop.Domain.Payroll;

public class FullTime : EmployeeBase //clase que hereda de EmployeeBase
{
    public decimal Monthly { get; } //propiedad de solo lectura unica de esta clase 

    public FullTime(string fullName, decimal monthly) : base(fullName)
    {
        if (monthly <= 0) throw new ArgumentOutOfRangeException(nameof(monthly)); //valida que el salario sea positivo
        Monthly = monthly;
    }

    public override decimal CalculatePayment() => Monthly; //implementa el metodo abstracto para calcular pago

    public override string BuildReport() => $"FullTime -> {FullName}: {Monthly:C0}"; //genera el reporte especifico para su clase
}
