using System;
using System.Runtime.Serialization;
// make the addition of numbers while it's < 3
namespace repit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            x= int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                soma += x;  // soma = soma + x
                
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}