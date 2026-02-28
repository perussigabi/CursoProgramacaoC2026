using System.Net;

namespace CursoProgramacao
{
    public class Class1
    {
        int valor1;
        int valor2;
        //Método Somar
        public void Soma()
        {
            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Total: {valor1 + valor2}");

        }

        public void Multiplicar()
        {
            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Total: {valor1 * valor2}");


        }

        public void Subtrair()
        {
            Console.WriteLine("Informe o valor 1");
            int valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor 2");
            int valor2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Total: {valor1 - valor2} ");
        }

        public void Dividir()
        {
            Console.WriteLine("Informe o valor 1");
           valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Total: {valor1 / valor2}");
        }
    }
}
