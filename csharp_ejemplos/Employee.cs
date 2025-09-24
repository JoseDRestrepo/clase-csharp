public class Employee
{
    private string _document; //propiedad privada donde almacenar el valor del documento
    public int Id { get; } //id con solo lectura
    public string FullName { get; set; } = ""; //propiedad con valor vacio por defecto
    public decimal BaseSalary { get; private set; } //propiedad con lectura y el set privado

    
    public string Document
    {
        get => _document; //get que almacena el valor en _document
    set //set que valida que el documento no este vacio
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Documento requerido"); //si es un dato vacio lanza un argumentexception
            _document = value.Trim();
        }
    }

    //el construtor de employee
    public Employee(int id, string fullName, decimal baseSalary, string document)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id)); //primero valida que el id sea > 0
        //se asignan los valores
        Id = id;
        FullName = fullName;
        SetBaseSalary(baseSalary); //se llama a la funcion SetBaseSalary()
        Document = document;
    }

    public void SetBaseSalary(decimal amount) // funcion que valida que el salario no sea < a un millon
    {
        if (amount < 1_000_000m) throw new ArgumentException("Salario mínimo no válido"); //si es menor a un millon lanza un ArgumentException
        //asigna el valor
        BaseSalary = amount;
    }
}

/* Ejercicio 1
    Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
    Agrega dos constructores: uno completo y otro con precio 0 por defecto.
    Crea 2 instancias en Main y muéstralas por consola.
    Criterio pedagógico: observa si validan datos en propiedades (no en la UI), y si los mensajes de error son claros.
 */
