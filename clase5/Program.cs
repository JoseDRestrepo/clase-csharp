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

//conversion de monedas POO
// Console.Write("Ingrese una cantidad de dinero (en cop): ");
// double pesos = double.Parse(Console.ReadLine());

// conversionMonedas conversion = new conversionMonedas();
// conversion.COP = pesos;
// conversion.imprimirDolar();
// conversion.imprimirEuros();
// conversion.imprimirLibras();

//cajero automatico POO
// atm cajero = new atm();

// Console.WriteLine("OPCIONES:");
// Console.WriteLine("Consultar saldo (1):");
// Console.WriteLine("Retirar dinero (2):");
// Console.WriteLine("Salir (3):");
// Console.Write("Seleccione su opción (por número): ");
// int opcion = int.Parse(Console.ReadLine());
// do{
//     if (opcion == 1)
//     {
//         cajero.imprimirSaldo();
//     }
//     else if (opcion == 2)
//     {
//         cajero.retirar();
//     }
//     else if (opcion == 3)
//     {
//         cajero.salir();
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Opción no válida. Intente nuevamente.");
//     }
//     Console.WriteLine("----------------------------------");
//     Console.WriteLine("OPCIONES:");
//     Console.WriteLine("Consultar saldo (1):");
//     Console.WriteLine("Retirar dinero (2):");
//     Console.WriteLine("Salir (3):");
//     Console.Write("Seleccione su opción (por número): ");
//     opcion = int.Parse(Console.ReadLine());
// } while (true);

//calculo IMC POO
// Console.Write("Ingrese su peso (en kg): ");
// double peso = double.Parse(Console.ReadLine());
// Console.Write("Ingrese su estatura (en metros): ");
// double estatura = double.Parse(Console.ReadLine());

// CalculoIMC imc = new CalculoIMC();
// imc.peso = peso;
// imc.estatura = estatura;
// imc.imprimirIMC();
