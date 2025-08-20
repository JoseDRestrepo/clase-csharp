// See https://aka.ms/new-console-template for more information
Console.WriteLine("oop");

//programacion estruscturada
//sumar dos numeros
// Console.Write("Ingrese el 1er num: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Ingrese el 2do num: ");
// int num2 = int.Parse(Console.ReadLine());

// int suma = num1 + num2;
// Console.WriteLine($"La suma es {suma}");

//programacion orientada a objetos

//instanciar la clase (crearun objeto de uan clase)
//sintaxis
//clase a instanciar, el objeto, new, constructor de la clase
// operacionAritmetica op1 = new operacionAritmetica();
// op1.numero1 = num1;
// op1.numero2 = num2;
// op1.imprimirSumar();

// operacionAritmetica op2 = new operacionAritmetica();
// op2.numero1 = 5;
// op2.numero2 = 10;
// op2.imprimirSumar();

// operacionAritmetica op3 = new operacionAritmetica();
// op3.numero1 = 20;
// op3.numero2 = 30;
// op3.imprimirSumar();

//conversion de monedas
Console.Write("Ingrese una cantidad de dinero (en cop): ");
double pesos = double.Parse(Console.ReadLine());

conversionMonedas conversion = new conversionMonedas();
conversion.COP = pesos;
conversion.imprimirDolar();
conversion.imprimirEuros();
conversion.imprimirLibras();
