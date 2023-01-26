using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aviao1;
            double aviao2;
            double aviao3;
            double aviao4;

            double quantAviao1;
            double quantAviao2;
            double quantAviao3;
            double quantAviao4;

            double valorUnit1;
            double valorUnit2;
            double valorUnit3;
            double valorUnit4;

            double total;



            Console.WriteLine("Digite o valor do primeiro avião:");
            aviao1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse modelo o senhor deseja?");
            valorUnit1 = double.Parse(Console.ReadLine());
            quantAviao1 = aviao1 * valorUnit1;

            {
                Console.WriteLine("Digite o valor do segundo avião:");
                aviao2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos desse modelo o senhor deseja?");
                valorUnit2 = double.Parse(Console.ReadLine());
                quantAviao2 = aviao2 * valorUnit2;
                total = quantAviao1 + quantAviao2;


                {
                    Console.WriteLine("Digite o valor do terceiro avião:");
                    aviao3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantos desse modelo o senhor deseja?");
                    valorUnit3 = double.Parse(Console.ReadLine());
                    quantAviao3 = aviao3 * valorUnit3;
                    total = quantAviao1 + quantAviao2 + quantAviao3;

                    {

                        Console.WriteLine("Digite o valor do quarto avião:");
                        aviao4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantos desse modelo o senhor deseja?");
                        valorUnit4 = double.Parse(Console.ReadLine());
                        quantAviao4 = aviao4 * valorUnit4;
                        total = quantAviao1 + quantAviao2 + quantAviao3 + quantAviao4;
                        Console.WriteLine("Fim da operação. O total a ser pago é de " + total + " reais");
                    }
                }


                {
                    Console.WriteLine("O subtotal é de " + total + " reais");
                }

            }

            {
                Console.WriteLine("Sua operação acabou. O total é de " + quantAviao1 + " reais");
            }

            Console.ReadLine();
        }
    }
}
