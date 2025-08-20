// See https://aka.ms/new-console-template for more information

int calificacion = 0;
int calificacion_parametro_centinela = -13;
int suma_calificaciones = 0;
int numero_calificaciones = 0;
int promedio_calificaciones = 0;

do
{
    Console.WriteLine("CALIFIQUE SU EXPERIENCIA DEL 1 AL 10");
    Console.WriteLine("Pesima: (1-2). Mala (3-4). Regular (5-6). Buena (7-8). Excelente (9-10)");
    Console.Write("Su nota: ");
    calificacion = int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------------------");
    if (calificacion > 0 && calificacion <= 10)
    {
        Console.WriteLine("Gracias por su opinión");
        Console.WriteLine("------------------------------------");
        numero_calificaciones++;
        suma_calificaciones += calificacion;
        promedio_calificaciones = suma_calificaciones / numero_calificaciones;
        Console.WriteLine($"El promedio de calificaciones es: {promedio_calificaciones}");
        Console.WriteLine("------------------------------------");
    }
    else
    {
        if (calificacion == calificacion_parametro_centinela)
        {
            Console.WriteLine("Saliendo...");
            Console.WriteLine("------------------------------------");
        } else
        {
            Console.WriteLine("El num debe ser del uno al diez");
            Console.WriteLine("------------------------------------");
        }
    }
} while (calificacion != calificacion_parametro_centinela);
