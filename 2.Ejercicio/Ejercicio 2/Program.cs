using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Programa para medir el Indice de Masa Corporal (IMC)");
        Console.WriteLine("Introduce tu altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce tu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);

        Console.WriteLine("Tu IMC es: " + imc);
        Console.WriteLine("Si tu IMC es menor de 18.5, tu peso es bajo");
        Console.WriteLine("Si tu IMC es entre 18.5 y 24.9, tu peso es normal");
        Console.WriteLine("Si tu IMC es mayor de 24.9, tu peso es alto");
        Console.WriteLine("Presione una tecla para cerrar el programa");
        Console.ReadKey();
    }
}
