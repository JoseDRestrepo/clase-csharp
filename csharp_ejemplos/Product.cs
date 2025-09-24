/* Ejercicio 1
    Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
    Agrega dos constructores: uno completo y otro con precio 0 por defecto.
    Crea 2 instancias en Main y muéstralas por consola.
    Criterio pedagógico: observa si validan datos en propiedades (no en la UI), y si los mensajes de error son claros.
 */

public class Product
{
    private string _name;
    public int Id { get; }
    public int Stock { get; }
    public decimal Price { get; }

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nombre requerido");
            _name = value;
        }
    }

    public Product(int id, string name, int stock, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nombre requerido", nameof(name));
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
        if (stock < 0) throw new ArgumentOutOfRangeException(nameof(stock));
        Id = id;
        Name = name;
        Stock = stock;
        Price = price;
    }

    public Product(int id, string name, int stock) : this(id, name, stock, 0)
    {
        
    }
}