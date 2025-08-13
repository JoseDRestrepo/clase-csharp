// See https://aka.ms/new-console-template for more information

int calificacion = 0;
int calificacion_parametro_centinela = -13;

do
{
    Console.WriteLine("CALIFIQUE SU EXPERIENCIA DEL 1 AL 10");
    Console.WriteLine("Pesima: (1-2). Mala (3-4). Regular (5-6). Buena (7-8). Excelente (9-10)");
    Console.Write("Su nota: ");
    calificacion = int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------------------");
} while (calificacion != calificacion_parametro_centinela);