// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programacion estructurada");
//Ejemplo manejo de variables

//Sintaxis de variables
//Tipo nombreVariable = valorInicial;

//Tipos de datos primitivos
// int edad = 30; // Entero
// Console.WriteLine($"Edad: {edad}");
// string nombre = "Juan"; // Cadena de texto
// Console.WriteLine($"Nombre: {nombre}");
// char valorInicial = 'J'; // Carácter
// Console.WriteLine($"Valor Inicial: {valorInicial}");

//Tipos de datos numericos
// float altura = 1.75f; // Flotante
// Console.WriteLine($"Altura: {altura} metros");
// double salario = 2500.50; // Doble precisión
// Console.WriteLine($"Salario: {salario} dólares");
// decimal precio = 19.99m; // Decimal
// Console.WriteLine($"Precio: {precio} dólares");

//Booleanos
// bool esEstudiante = true; // Booleano
// Console.WriteLine($"¿Es estudiante? {esEstudiante}");

//Tipos de datos fecha
// DateTime fechaNacimiento = new DateTime(1993, 5, 15); // Fecha y hora
// DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now); // Solo fecha

//Concatenar
// Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, valorInicial: {valorInicial}");

// Operaciones con variables
// int num1 = 10;
// int num2 = 5;
// int resultadoSuma = num1 + num2; // Suma
// Console.WriteLine($"Resultado de la suma: {resultadoSuma}");

//Ejemplo sumar dos números
// Console.WriteLine("Ingrese el primer número: ");
// int numeroA = Convert.ToInt32(Console.ReadLine()); /// Convert para parsear un dato (Conversion de tipo)
// Console.Write("Ingrese el segundo número: ");
// int numeroB = int.Parse(Console.ReadLine()); // Parse para convertir un string a int
// int resultados = numeroA + numeroB; // Sumar
// Console.WriteLine($"Resultado de la suma: {resultados}");

//Conversiones de tipos 
// string numeroComoTexto = edad.ToString(); // Convertir entero a cadena
// int edadConvertida = nombre.Parse(); // Convertir cadena a entero


// Tipos de datos complejos
// object persona = new { Nombre = "Juan", Edad = 30 }; // Objeto anónimo

//ejercicio 1
// Console.WriteLine("PRIMER EJERCICIO");
// Console.Write("Nombre: "); //la consola solicita el nombre
// string nombre = Console.ReadLine(); //la consola lee el nombre ingresado
// Console.Write("Edad: "); //lo mismo con la edad
// int edad = int.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a int
// Console.Write("Estatura (en metros): "); //lo mismo con la estatura
// double estatura = double.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a double
// Console.Write("Peso (en kg): "); //lo mismo con el peso
// double peso = double.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a double

// double imc = peso / Math.Pow(estatura, 2); //calcula el imc con los datos recibidos x consola
// Console.WriteLine($"Tu IMC es {imc}."); //se imprime el imc calculado

//Validación de datos ingresados
// if (nombre == null || edad <= 0 || estatura <= 0 || peso <= 0) //valida que haya ingresado los datos o si son válidos
// {
//     Console.WriteLine("Datos inválidos. Por favor, ingresa valores válidos."); //se imprime mensaje avisando que los datos son inválidos
// }
// else
// {
//     Console.WriteLine($"Hola {nombre}, tu IMC es {imc}."); //imprime el nombre y el imc con dos decimales
// }

//ejercicio 2
// Console.WriteLine("SEGUNDO EJERCICIO");
// Console.Write("Nombre: "); //se piden los datos como en el ejercicio anterior
// string name = Console.ReadLine();
// Console.Write("COP: ");
// double cop = double.Parse(Console.ReadLine()); //el dato lo ingreso como double pq luego lo voy a usar para multiplicarlo por un decimal y asi converlirlo a las otras monedas

// double usd = cop * 0.00024; 
// double eur = cop * 0.00021; //calculo el valor convertido a otras monedas
// double gbp = cop * 0.00018;

// Console.WriteLine($"Cantidad de COP: {cop}"); 
// Console.WriteLine($"Convertido a Dólares: {usd}"); //se imprimen los resultados de las conversiones
// Console.WriteLine($"Convertido a Euros: {eur}");
// Console.WriteLine($"Convertido a Libras: {gbp}");
