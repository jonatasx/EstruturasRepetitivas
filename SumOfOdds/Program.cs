using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds
{//make the sum of all odds between 2 numbers
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y, min, max, Soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine()); 

            if (x < y)
            {
                min = x;
                max = y;

            }
            else
            {
                min = y;
                max = x;
            } //só para garantir que o mínimo tera o menor valor e o máximo o maior valor
            Soma = 0;
            for(int i = min+1; i<max; i++) //fazendo contagens de forma crescente
            {
                if(i % 2 != 0) //definindo se um número é impar
                {
                    Soma = Soma + i;
                }
            }

            Console.WriteLine(Soma);
            Console.ReadLine();
        }
    }
}
