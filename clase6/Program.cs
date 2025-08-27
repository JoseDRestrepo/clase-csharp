// Console.Write("Tipo de vehiculo (1. taxi) (2. moto): ");
// short tipo_vehi = short.Parse(Console.ReadLine());

// Console.Write("Marca: ");
// string marca = Console.ReadLine();

// Console.Write("Linea: ");
// string linea = Console.ReadLine();

// Console.Write("Modelo: ");
// string modelo = Console.ReadLine();

// Console.Write("Placa: ");
// string placa = Console.ReadLine();

// Motocicleta moto = new Motocicleta() { Placa = placa };

// Taxi taxi1 = new Taxi() { Modelo = modelo };

// if (tipo_vehi == 1) {
//     taxi1.VerEncender();
// } else {
//     moto.VerEncender();
// }

// //polimorfismo
// Console.Write("Enter the animal code (1. Dog, 2. Cat, 0. Exit): ");
// string? animalCodeInput = Console.ReadLine();
// short AnimalCode = 0;
// if (!string.IsNullOrEmpty(animalCodeInput) && short.TryParse(animalCodeInput, out short codeResult))
// {
//     AnimalCode = codeResult;
// }

// while (AnimalCode != 0) {
//     Console.Write("Enter the animal id: ");
//     string? AnimalId = Console.ReadLine();
//     Console.Write("Enter the animal age: ");
//     string? animalAgeInput = Console.ReadLine();
//     short AnimalAge = 0;
//     if (!string.IsNullOrEmpty(animalAgeInput) && short.TryParse(animalAgeInput, out short ageResult))
//     {
//         AnimalAge = ageResult;
//     }

//     switch (AnimalCode) {
//         case 1:
//             var MyDog = new Dog() {
//                 id = AnimalId ?? "",
//                 age = AnimalAge
//             };        
//             Console.WriteLine($"The dog data is: {MyDog.id}. And age: {MyDog.age}");
//             MyDog.view_dog_sound();
//             break;
//         case 2:
//             var MyCat = new Cat() {
//                 id = AnimalId ?? "",
//                 age = AnimalAge
//             };   
//             Console.WriteLine($"The cat data is: {MyCat.id}. And age: {MyCat.age}");
//             MyCat.view_cat_sound();
//             break;
//         default:
//             Console.WriteLine("Animal does not exist");
//             break;
//     }
//     Console.Write("Enter the animal code (1. Dog, 2. Cat, 0. Exit): ");
//     animalCodeInput = Console.ReadLine();
//     if (!string.IsNullOrEmpty(animalCodeInput) && short.TryParse(animalCodeInput, out codeResult))
//     {
//         AnimalCode = codeResult;
//     }
//     else
//     {
//         AnimalCode = 0;
//     }
// }

Console.Write("Introduzca su peso en kg: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Introduzca su altura en metros: ");
double altura = double.Parse(Console.ReadLine());

CalculoIMC imc = new CalculoIMC();
imc.Calculo(peso, altura);
imc.impresionCalculo();

double precioDolar = 0.00025;
double precioEuro = 0.00023;
double precioLibra = 0.00020;

Console.Write("Introduzca la cantidad en pesos colombianos a convertir: ");
double pesos = double.Parse(Console.ReadLine());
CalculoMonedas dolar = new CalculoMonedas();
dolar.Calculo(pesos, precioDolar);
Console.Write("Dolar: ");
dolar.impresionConversion();
CalculoMonedas euro = new CalculoMonedas();
Console.Write("Euro: ");
euro.Calculo(pesos, precioEuro);
euro.impresionConversion();
CalculoMonedas libra = new CalculoMonedas();
libra.Calculo(pesos, precioLibra);
Console.Write("Libra: ");
libra.impresionConversion();
