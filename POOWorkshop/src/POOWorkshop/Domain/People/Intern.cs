namespace POOWorkshop.Domain.People;

public class Intern : EmployeeFullTimePerson
{
    public int months { get; } 
    public Intern(string name, decimal salary, int months) : base(name, salary) 
    {
        if (months < 0) throw new ArgumentOutOfRangeException(nameof(months));
        this.months = months;
    }

    public override string Describe() => $"Interino: {FullName}, salario: {Salary:C0}, meses: {months}";
}