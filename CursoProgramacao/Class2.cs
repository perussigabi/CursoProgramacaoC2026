namespace CursoProgramacao
{
    public class Class2
    {
        public void ValorPar()
        {
            Console.WriteLine("Informe um valor:");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");

            }
        }

        public void MaiorIdade()
        {
            Console.WriteLine("Informe a idade:");
            int idade = int.Parse(Console.ReadLine()!);
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }

        public void Nota()
        {
            Console.WriteLine("Informe a nota:");
            int nota = int.Parse(Console.ReadLine()!);

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
