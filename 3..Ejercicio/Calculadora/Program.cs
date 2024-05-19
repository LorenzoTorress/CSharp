namespace Calculadora;
class Program
{
    static void Main(string[] args)
    {
        Metodos metodos = new Metodos();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Programa de la calculadora");
            Console.WriteLine("Seleccione que operacion quiera realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            string operacion = Console.ReadLine();

            if (operacion == "5")
            {
                Console.Clear();
                Console.WriteLine("Saliendo del programa");
                Console.WriteLine("Presione cualquier tecla para cerrar");
                Console.ReadKey();
                break;
            }
            switch (operacion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Operacion seleccionada: Suma");
                    metodos.Numeros();
                    Console.WriteLine(metodos.Suma(metodos.Num1, metodos.Num2));
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Operacion seleccionada: Resta");
                    metodos.Numeros();
                    Console.WriteLine(metodos.Resta(metodos.Num1, metodos.Num2));
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Operacion seleccionada: Multiplicación");
                    metodos.Numeros();
                    Console.WriteLine(metodos.Multiplicación(metodos.Num1, metodos.Num2));
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Operacion seleccionada: División");
                    metodos.Numeros();
                    Console.WriteLine(metodos.División(metodos.Num1, metodos.Num2));
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;      
                default:
                    Console.WriteLine("Operacion no valida");
                    break;

            }
        }               
    }
}
