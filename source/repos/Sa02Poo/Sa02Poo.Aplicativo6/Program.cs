using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sa02Poo.Aplicativo6
{
    public class Program
    {

        static void Main(string[] args)
        {
            Aplicativo6RN app6 = new Aplicativo6RN();

            double aviao1;
            double aviao2;
            double aviao3;
            double aviao4;

            double qntd1;
            double qntd2;
            double qntd3;
            double qntd4;

            double valorUnit1;
            double valorUnit2;
            double valorUnit3;
            double valorUnit4;

            double total;


            Console.WriteLine("Digite o valor do primeiro avião:");
            aviao1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse modelo desseja?");
            valorUnit1= double.Parse(Console.ReadLine());
            qntd1 = aviao1 * valorUnit1;
          

            Console.WriteLine("Digite o valor do segundo avião:");
            aviao2= double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse modelo deseja?");
            valorUnit2 = double.Parse(Console.ReadLine());
            qntd2 = aviao2* valorUnit2;
            total = qntd1 + qntd2;

            Console.WriteLine("Digite o valor do terceiro avião");
            aviao3= double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse modelo deseja?");
            valorUnit3 =double.Parse(Console.ReadLine());
            qntd3 = aviao3* valorUnit3;
             total = qntd1 + qntd2 + qntd3;

            Console.WriteLine("Digite o valor do quarto avião:");
            aviao4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse modelo deseja?");
            valorUnit4= double.Parse(Console.ReadLine());
            qntd4 = aviao4 * valorUnit4;
            total = qntd1 + qntd2 + qntd3 + qntd4;
            Console.WriteLine("Fim da operação. O total a ser pago é de " + total + " reais");

            Console.WriteLine("O subtotal é de " + total + " reais");

            double v = app6.SomarAviaoes(aviao1, aviao2, aviao3, aviao4);
            double resultado = v;
            Console.WriteLine("Sua operação acabou. O total é de: " + resultado + " reais");
            Console.ReadKey();

           
        }      

    }
}