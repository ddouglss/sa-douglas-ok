using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplicativo7RN app7= new Aplicativo7RN();

            int peca1;
            int peca2;
            int peca3;
            int peca4;
            int peca5;
          

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

            

            int v = app7.SomarPecas(peca1, peca2, peca3, peca4, peca5);
            int resultado = v;
            Console.WriteLine("total R$: " + resultado + " reais");
            Console.ReadKey();
        }
    }
}
