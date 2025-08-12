// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estructuras condicionales");

Console.WriteLine("Estructua IF");

// sbyte PARAMETRO_EDAD = 18;
// Console.Write("Escriba su edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());

//if simple 
// if (edad >= PARAMETRO_EDAD) {
//     Console.WriteLine("Sos mayor de edad");
// } 

//if compuesto
// if (edad >= PARAMETRO_EDAD) {
//     Console.WriteLine("Sos mayor de edad");
// } else {
//     Console.WriteLine("Sos menor de edad");
// }


//if anidado

// Console.Write("Estado civil: ");
// string? estado_civil = Console.ReadLine();
// Console.Write("Escriba su edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// Console.Write("Responsable (true o false): ");
// bool responsable = bool.Parse(Console.ReadLine());
// Console.Write("Hijos: ");
// string? hijos = Console.ReadLine();

// string PARAMETRO_ESTADO_CIVIL = "soltero";
// sbyte PARAMETRO_EDAD = 20;
// bool PARAMETRO_RESPONSABLE = true;
// string PARAMETRO_HIJOS = "con hijos";

// if (estado_civil == PARAMETRO_ESTADO_CIVIL)
// {
//     if (edad >= PARAMETRO_EDAD)
//     {
//         if (responsable == PARAMETRO_RESPONSABLE)
//         {
//             if (hijos != PARAMETRO_HIJOS)
//             {
//                 Console.WriteLine("Hombre ideal");
//             }
//             else
//             {
//                 Console.WriteLine("Hombre no ideal: tiene hijos");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Hombre no ideal: es irresponsable");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Hombre no ideal: muy joven");        
//     }
// }
// else
// {
//     Console.WriteLine("Hombre no ideal: No es soltero");
// } 

//uso de operadores logicos 
//-Y = && 
//- O = || 
// if (estado_civil == PARAMETRO_ESTADO_CIVIL && edad >= PARAMETRO_EDAD && responsable == PARAMETRO_RESPONSABLE && hijos != PARAMETRO_HIJOS)
// {
//     Console.WriteLine("Hombre ideal");
// }
// else
// {
//     Console.WriteLine("Hombre no ideal");
// }

//tipo de producto
// Console.Write("Tipo de producto: ");
// string? tipo_producto = Console.ReadLine();
// string PARAMETRO_CELULAR = "celular";
// string PARAMETRO_TV = "tv";
// string PARAMETRO_COMPUTADORA = "computadora";

// int precio = 0;

// if (tipo_producto == PARAMETRO_CELULAR)
// {
//     precio = 600000;
// }
// else
// {
//     if (tipo_producto == PARAMETRO_TV)
//     {
//         precio = 2100000;
//     }
//     else
//     {
//         if (tipo_producto == PARAMETRO_COMPUTADORA)
//         {
//             precio = 7500000;
//         }
//         else
//         {
//             Console.WriteLine("Producto no valido");
//         }
//     }
// }
// Console.WriteLine($"Precio: ${precio}");

// if (tipo_producto == PARAMETRO_CELULAR || tipo_producto == PARAMETRO_TV || tipo_producto == PARAMETRO_COMPUTADORA)
// {
//     precio = 2000000;
// }
// else
// {
//     Console.WriteLine("Producto no valido");
// }

//estructura SWITCH
// switch (tipo_producto)
// {
//     case "celular":
//         precio = 700000;
//         break;
//     case "tv":
//         precio = 2100000;
//         break;
//     case "computador":
//         precio = 7500000;
//         break;
//     default:
//         Console.WriteLine("Producto no valido");
//         break;
// }
// Console.WriteLine($"Precio: ${precio}");

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
// Console.Write("Seleccione su opción (por número): ");
// int opcion = int.Parse(Console.ReadLine());

// if (opcion == 1)
// {
//     DateTime fecha_actual = DateTime.Now;
//     Console.WriteLine($"fecha actual: {fecha_actual}");
// }
// else
// {
//     if (opcion == 2)
//     {
//         Console.Write("Escriba nombre:");
//         string? nombre = Console.ReadLine();
//         Console.WriteLine($"Su nombre es: {nombre}");
//     }
//     else
//     {
//         if (opcion == 3)
//         {
//             string mensaje_motivacional = "";
//             Console.WriteLine(mensaje_motivacional);
//         }
//         else
//         {
//             if (opcion == 4)
//             {
//                 Console.WriteLine("Saliendo...");
//             }
//             else
//             {
//                 Console.WriteLine("Opción no valida");
//             }
//         }
//     }
// }

// determinar niveles/rangos de valgo de rodilla 

// Console.Write("Angulo de desviacion en la rodilla: ");
// int angulo_desviacion = int.Parse(Console.ReadLine());

// if (angulo_desviacion < 10)
// {
//     Console.WriteLine("Grado I");
// }
// else
// {
//     if (angulo_desviacion <= 20)
//     {
//         Console.WriteLine("Grado II");
//     }
//     else
//     {
//         if (angulo_desviacion > 20)
//         {
//             Console.WriteLine("Grado III");
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
//         Console.WriteLine("Saliendo del sistema...");
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
// } while (opcion != 3);
