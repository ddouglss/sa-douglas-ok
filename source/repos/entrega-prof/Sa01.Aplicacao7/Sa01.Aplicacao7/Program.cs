using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peca1;
            int peca2;
            int peca3;
            int peca4;
            int peca5;
            int total;

            Console.WriteLine("Digite o valor da primeira peça: ");
            peca1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda peça: ");
            peca2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira peça: ");
            peca3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da quarta peça: ");
            peca4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da quinta peça: ");
            peca5 = Int32.Parse(Console.ReadLine());

            total = peca1 + peca2 + peca3 + peca4 + peca5;
            Console.WriteLine("O valor total das peças desejadas é de " + total + " reais");
        }
    }
}
