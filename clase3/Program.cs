// See https://aka.ms/new-console-template for more information

//ejercicio IMC
// for (int i = 0; i < 3; i++) //se repite 3 veces
// {
//     Console.WriteLine("PRIMER EJERCICIO");
//     Console.Write("Nombre: "); //la consola solicita el nombre
//     string nombre = Console.ReadLine(); //la consola lee el nombre ingresado
//     Console.Write("Edad: "); //lo mismo con la edad
//     int edad = int.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a int
//     Console.Write("Estatura (en metros): "); //lo mismo con la estatura
//     double estatura = double.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a double
//     Console.Write("Peso (en kg): "); //lo mismo con el peso
//     double peso = double.Parse(Console.ReadLine()); //lee el dato y lo parsea/convierte a double

//     double imc = peso / (estatura * estatura); //calcula el imc con los datos recibidos x consola
//     Console.WriteLine($"Tu IMC es {imc}."); //se imprime el imc calculado
// }

//1.Menu de opciones:
//a)mostrar la fecha actual
//b)mostrar su nombre
//c)mensaje motivador 
//d)salir

// Console.WriteLine("OPCIONES:");
// Console.WriteLine("mostrar la fecha actual (1):");
// Console.WriteLine("mostrar su nombre (2):");
// Console.WriteLine("mensaje motivador (3):");
// Console.WriteLine("salir (4):");

// int opcion = 0;
// int opcion_parametro_centinela = 4;

// do
// {
//     Console.WriteLine("----------------------------------");
//     Console.Write("Seleccione su opción (por número): ");
//     opcion = int.Parse(Console.ReadLine());
//     if (opcion == 1)
//     {
//         DateTime fecha_actual = DateTime.Now;
//         Console.WriteLine($"Fecha actual: {fecha_actual}");
//     }
//     else
//     {
//         if (opcion == 2)
//         {
//             Console.Write("Escriba nombre: ");
//             string? nombre = Console.ReadLine();
//             Console.WriteLine($"Su nombre es: {nombre}");
//         }
//         else
//         {
//             if (opcion == 3)
//             {
//                 string mensaje_motivacional = "Vos podes";
//                 Console.WriteLine(mensaje_motivacional);
//             }
//             else
//             {
//                 if (opcion == 4)
//                 {
//                     Console.WriteLine("Saliendo...");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Opción no valida, intente nuevamente");
//                 }
//             }
//         }
//     }
// } while (opcion != opcion_parametro_centinela);

// int angulo_desviacion = 0;
// int angulo_desviacion_parametro_centinela = -12;

// while (angulo_desviacion != angulo_desviacion_parametro_centinela) {
//     Console.Write("Angulo de desviacion en la rodilla: ");
//     angulo_desviacion = int.Parse(Console.ReadLine());

//     if (angulo_desviacion > 0 && angulo_desviacion < 10)
//     {
//         Console.WriteLine("Grado I");
//     }
//     else
//     {
//         if (angulo_desviacion >= 10 && angulo_desviacion <= 20)
//         {
//             Console.WriteLine("Grado II");
//         }
//         else
//         {
//             if (angulo_desviacion > 20)
//             {
//                 Console.WriteLine("Grado III");
//             }
//         }
//     }
// }

//ATM: Mostrar 3 opciones 
//1.Consultar saldo
//2.Retirar dinero
//3.Salir
//El saldo inicial debe ser de 500k, si se elige retirar entonces le debe de solicitar el monto
//verificar si hay saldo suficiente, descontar el retiro del saldo, mostrar el saldo actualizado
//mostrar un mensaje de despedida

// Console.WriteLine("ATM");
// int saldo = 500000;
// Console.WriteLine("OPCIONES:");
// Console.WriteLine("Consultar saldo (1):");
// Console.WriteLine("Retirar dinero (2):");
// Console.WriteLine("Salir (3):");
// Console.Write("Seleccione su opción (por número): ");
// int opcion = int.Parse(Console.ReadLine());
// do{
//     if (opcion == 1)
//     {
//         Console.WriteLine($"Saldo actual: ${saldo}");
//     }
//     else if (opcion == 2)
//     {
//         Console.Write("Ingrese el monto a retirar: ");
//         int monto_retiro = int.Parse(Console.ReadLine());
//         if (monto_retiro <= saldo)
//         {
//             saldo = saldo - monto_retiro;
//             Console.WriteLine($"Retiro exitoso. Saldo actualizado: ${saldo}");
//         }
//         else
//         {
//             Console.WriteLine("Saldo insuficiente para el retiro.");
//         }
//     }
//     else if (opcion == 3)
//     {
//         Console.WriteLine("Saliendo...");
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


//*CLASE 3
//ciclos 
//ciclo for 
//for (int i = 0; i < length; i++)
//inicio   hastaDonde   incremento
//{

//}

//for (int i = 0; i < 10; i++)
//{
//Console.Write("Edad: ");
//sbyte edad = sbyte.Parse(Console.ReadLine());
//Console.WriteLine($"Su edad es: {edad}")
//}

//ciclo while: para cuando no se sabe cuantas veces se va a repetir
//int j = 0;
//while (j <= 6)
//{
//Console.Write("Edad: ");
//sbyte edad = sbyte.Parse(Console.ReadLine());
//}

//Console.Write("Edad: ");
//sbyte edad = sbyte.Parse(Console.ReadLine());
//sbyte edad_parametro_centinela = 99;
//while (edad != edad_parametro_centinela)
//{
//Console.WriteLine("Puede ingresar");
//Console.Write("Edad: ");
//edad = sbyte.Parse(Console.ReadLine());
//}

// do while: no se sabe cuantas veces se va a repitir, pero 

// sbyte edad = 0;
// sbyte edad_parametro_centinela = 99;

// do
// {
//     Console.Write("Edad: ");
//     edad = sbyte.Parse(Console.ReadLine());
// } while (edad != edad_parametro_centinela)

//encapsular el ejercicio de indice de masa muscular
//el del ATM
//el resto

//ciclo foreach: se utiliza para recuperar informacion de arrays, colecciones o listas
//sintaxis
//foreach (var item in collection)
//{
//  pasos, tareas, actividades a realizar
//}

//variable 
//string nombre = "Ana";

//array 
// string[] nombres = {"Ana", "Maria", "Jose", "Andres"};

// foreach (var nombre in nombres)
// {
//     Console.WriteLine(nombre);
// }

//lista 

//List<string> nombres = new List<string>();

//llenar la lista
// nombres.Capacity(); //caracteristicas, en prog. propiedad o atributos
// nombres.Add(); //acciones, en prog. metodos o funciones
// nombres.Add("Ana");
// nombres.Add("Maria");
// nombres.Add("Jose");
// nombres.Add("Andres Luis");

// foreach (string nombre in nombres)
// {
// Console.WriteLine(nombre);
// }

//list de numeros

// List<int> anios = new List<int>();

// anios.Add(2001);
// anios.Add(2010);
// anios.Add(2020);
// anios.Add(2024);

// foreach (int anio in anios)
// {
// Console.Write($"{anio} - ");
// }

//diccionario (sintaxis)
//Dictionary<tipo dato key, value> nombre_diccionario = new Dictionary<tipo dato key, value>()
//{
//{key, value}
//};

// Dictionary<int, string> lista_productos = new Dictionary<int, string>()
// {
//     {1, "Cebolla"},
//     {2, "Mango"},
//     {3, "Mamoncillos"}
// };

// foreach (var producto in lista_productos)
// {
//     Console.WriteLine($"{producto.Key}. {producto.Value}");
// }

//un inventario de tienda con cntrl de stock 
//un diccionario/lista/array con los productos, un menu donde pueda retirr productos

// Console.WriteLine("Bienvenido al inventario de la tienda");
// string[] productos = { "Camiseta", "Polo", "Jeans", "Chaqueta", "Zapatos" };
// int[] stock = { 10, 5, 8, 3, 6 };
// Console.WriteLine("Productos disponibles:");
// for (int i = 0; i < productos.Length; i++)
// {
//     Console.WriteLine($"{i + 1}. {productos[i]} - Stock: {stock[i]}");
// }
// int opcion = 0;
// int opcion_parametro_centinela = -1;
// do {
//     Console.Write("Seleccione el número del producto que desea retirar: ");
//     opcion = int.Parse(Console.ReadLine()) - 1;
//     if (opcion >= 0 && opcion < productos.Length)
//     {
//         if (stock[opcion] > 0)
//         {
//             stock[opcion]--;
//             Console.WriteLine($"Has retirado un {productos[opcion]}. Stock restante: {stock[opcion]}");
//         }
//         else
//         {
//             Console.WriteLine($"No hay stock para {productos[opcion]}");
//         }
//     }
//     else
//     {
//         if (opcion == opcion_parametro_centinela - 1) {
//             Console.WriteLine("Saliendo...");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Opción no válida.");
//         }
//     }
// } while (true);
