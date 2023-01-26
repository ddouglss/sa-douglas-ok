using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double aviao1, aviao2, soma = 0;

            Console.WriteLine("Digite o valor do PRIMEIRO avião:");
            aviao1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do SEGUNDO avião:");
            aviao2 = double.Parse(Console.ReadLine());

            soma = aviao1 + aviao2;

            Console.WriteLine("A soma dos preços dos aviões são: " + soma);
            Console.ReadLine();
           
        }
    }
}
