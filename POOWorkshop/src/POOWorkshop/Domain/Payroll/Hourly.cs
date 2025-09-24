namespace POOWorkshop.Domain.Payroll;

public class Hourly : EmployeeBase 
{
    private decimal _bonus = 0m; //campo privado para almacenar el bono
    public decimal Rate { get; } 
    public int Hours { get; }

    public void SetBonus(decimal bonus) 
    {
        if (bonus < 0m) throw new ArgumentOutOfRangeException(nameof(bonus));
        _bonus = bonus;
    }

    public Hourly(string fullName, decimal rate, int hours, decimal bonus) : base(fullName) //constructor de la clase 
    {
        if (rate <= 0) throw new ArgumentOutOfRangeException(nameof(rate)); //validaciones para rate y hours
        if (hours < 0) throw new ArgumentOutOfRangeException(nameof(hours));
        Rate = rate;
        Hours = hours;
        if (bonus < 0m) throw new ArgumentOutOfRangeException(nameof(bonus));
        SetBonus(bonus);
    }

    public Hourly(string fullName, decimal rate, int hours) : this(fullName, rate, hours, 0m) 
    {
    }

    public override decimal CalculatePayment() => Rate * Hours + _bonus;
    //sobreescribe el metodo para calcular el pago segun su logica
    public override string BuildReport() => $"Hourly -> {FullName}: {Rate:C0} x {Hours} + {_bonus:C0} = {CalculatePayment():C0}";
    //sobreescribe el metodo para generar el reporte especifico de su clase
    
}
