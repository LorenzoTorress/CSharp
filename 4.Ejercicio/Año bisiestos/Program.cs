using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Programa de año bisiestos");
            Console.WriteLine("Ingrese el año");
            int Año = Convert.ToInt32(Console.ReadLine());
            Año = Año % 4;
            if (Año == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Cerrar?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            int Cerrar = Convert.ToInt32(Console.ReadLine());
            if (Cerrar == 1)
            {
                Console.WriteLine("Cerrando programa...");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                break;
            }
            
        }

    }
}
