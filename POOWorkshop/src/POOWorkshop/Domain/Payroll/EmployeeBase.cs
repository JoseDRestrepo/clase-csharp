using POOWorkshop.Domain.Interfaces;

namespace POOWorkshop.Domain.Payroll;

public abstract class EmployeeBase : IPayable, IReportable //clase abstracta que implementa las dos interfaces
{
    public string FullName { get; } //solo lectura

    protected EmployeeBase(string fullName) //constructor protegido
    {
        if (string.IsNullOrWhiteSpace(fullName)) //valida que no sea nulo o vacio
            throw new ArgumentException("FullName required", nameof(fullName));
        FullName = fullName.Trim(); //asigna el valor recortando espacios en blanco
    }

    public virtual string Describe() => $"Empleado: {FullName}"; //metodo virtual que puede ser sobreescrito

    public abstract decimal CalculatePayment(); //metodo abstracto para el calculo de pago
    public abstract string BuildReport(); //metodo abstracto para generar reporte
}
