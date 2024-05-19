using System;

namespace Calculadora;
public class Metodos
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public void Numeros()
    {
        Console.WriteLine("Ingrese el primer número:");
        Num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        Num2 = int.Parse(Console.ReadLine());
    }

    public string Suma(int Num1, int Num2)
    {
        return "El Resultado es: " + (Num1 + Num2);
    }

    public string Resta(int Num1, int Num2)
    {
        
        return "El Resultado es: " + (Num1 - Num2);
    }

    public string Multiplicación(int Num1, int Num2)
    {
        return "El Resultado es: " + (Num1 * Num2);
    }

    public string División(int Num1, int Num2)
    {
        if (Num2 == 0)
        {
            return "No se puede dividir por 0";
        }
        else 
        {
            return "El Resultado es: " + (Num1 / Num2);
        }
        
    }
    
}
