public class Person //crea una clase persona
{
    public string FullName { get; } //solo lectura
    public Person(string fullName) => FullName = fullName; //construnctor de la clase persona
    public virtual string Describe() => $"Persona: {FullName}"; //metodo de descipcion de cada persona, servira para imprimir sus nombres
}

public class EmployeeFullTime : Person //clase hija de person
{
    public decimal Salary { get; } //solo lectura
    public EmployeeFullTime(string name, decimal salary) : base(name) => Salary = salary; //contructor de clase hija, añade el parametro salary
    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}"; //se sobreescribe el metodo Describe
}

public sealed class Contractor : Person //clase hija de Person
{
    public decimal HourRate { get; } //solo lectura
    public Contractor(string name, decimal hourRate) : base(name) => HourRate = hourRate; //añade el parametro hourRate
}

/* Ejercicio 2
    Crea Manager : EmployeeFullTime con propiedad TeamSize.
    Override Describe() para incluir tamaño de equipo.
    Instancia Person, EmployeeFullTime, Manager, Contractor y llama Describe().
 */

public class Manager : EmployeeFullTime
{
    public int TeamSize { get; }
    public Manager(string name, decimal salary, int teamSize) : base(name, salary) => TeamSize = teamSize;
    public override string Describe() => $"Manager: {FullName}, salario: {Salary:C0}, equipo: {TeamSize}";   
}