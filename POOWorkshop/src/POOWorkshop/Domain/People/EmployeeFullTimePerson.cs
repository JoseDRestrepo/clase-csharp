namespace POOWorkshop.Domain.People;

public class EmployeeFullTimePerson : Person //clase derivada de Person
{
    public decimal Salary { get; } //propiedad de solo lectura

    public EmployeeFullTimePerson(string name, decimal salary) : base(name) //constructor
    {
        if (salary <= 0) throw new ArgumentOutOfRangeException(nameof(salary)); //validacion
        Salary = salary;
    }

    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}"; 
    //sobreescritura del metodo describe
}
