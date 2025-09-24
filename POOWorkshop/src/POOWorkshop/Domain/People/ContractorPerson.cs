namespace POOWorkshop.Domain.People;

// Sellada: no admite más herencia
public sealed class ContractorPerson : Person //clase derivada de Person
{
    public decimal HourRate { get; } //propiedad de solo lectura
    public ContractorPerson(string name, decimal hourRate) : base(name) //constructor
    {
        if (hourRate <= 0) throw new ArgumentOutOfRangeException(nameof(hourRate));
        HourRate = hourRate;
    }
    // contractor esta sellado porque no se necesita que nadie herede de esta clase, asi se evita que alguien lo haga
    // y se asegura que la clase no se modifique, manteniendo su comportamiento original
}
