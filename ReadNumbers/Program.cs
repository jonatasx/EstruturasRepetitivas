using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace ReadNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i=1; i<=N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x; // soma = soma + x
            }
           Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
