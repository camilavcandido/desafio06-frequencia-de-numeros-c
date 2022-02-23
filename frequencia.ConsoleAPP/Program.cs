using System;

namespace frequencia.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequência");

            Console.WriteLine("Digite a quantidade de valores da sequencia: ");
            int qtdN = int.Parse(Console.ReadLine());

            int[] arrayNumeros = new int[qtdN];

            for (int k = 0; k < qtdN; k++)
            {
                Console.WriteLine("Digite um valor: ");
                arrayNumeros[k] = int.Parse(Console.ReadLine());

            }

            Array.Sort(arrayNumeros); //ordena em ordem crescente

            int i = 0, j = 0;

            while (i < qtdN)
            {
                int n = arrayNumeros[i];
                int qtd = 0;

                while (arrayNumeros[i] == arrayNumeros[j])
                {
                    qtd++;
                    j++;

                    if (j == qtdN)
                    {
                        break;
                    }
                }
                Console.WriteLine(n + " apareceu " + qtd + " vez(es)");
                i = j;
            }


        }
    }
}
