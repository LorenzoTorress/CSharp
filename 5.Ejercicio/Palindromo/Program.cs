using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            string[] Palabras = new string[2]; // Array de 2 elementos porque si no, no deja usar .Reverse()
            Console.WriteLine("Programa para verificar palindromos");
            Console.WriteLine("Ingrese su palabra o frase");
            Palabras[0] = Console.ReadLine();
            Palabras[1] = new string(Palabras[0].Reverse().ToArray()); // Al usar ToArray, transformo el IEnumerablechar en un array. Permitiendo que el if funcione
            if (Palabras[0] == Palabras[1])
            {
                Console.WriteLine("La palabra o frase es palindromo");
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("La palabra o frase no es palindromo");
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("Desea continuar?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            if (Console.ReadLine() == "2")
            {
                Console.Clear();
                Console.WriteLine("Presione una tecla para cerrar el programa");
                Console.ReadKey();
                break;
            }
        }
    }
}
// La razon por la cual uso .ToArray() al contrario de To.String es que si uso el To.String no funcionaria el if
// Ya que el To.String es de tipo char y el To.Array es de tipo char[]