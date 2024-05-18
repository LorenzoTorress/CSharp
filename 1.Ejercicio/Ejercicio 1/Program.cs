class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Programa para realizar promedio de 3 números");
            Console.WriteLine("Ingrese el primer número");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El promedio de los 3 números es " + (Num1 + Num2 + Num3) / 3);
            Console.WriteLine("Desea continuar?");
            Console.WriteLine("Si = si");
            Console.WriteLine("No = no");
            Console.Write("Respuesta: ");
            string Continuar = Console.ReadLine();
            Continuar = Continuar.ToLower();
            if (Continuar == "no")
            {
                Console.Clear();
                Console.WriteLine("Presiona una tecla para terminar el programa");
                Console.ReadKey();
                break;
            }
        }
    }
}

