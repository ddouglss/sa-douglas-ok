using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual, Subtracao = 0;

            Console.WriteLine("Olá, digite o ano atual que estamos!: ");
            AnoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Vou lhe falar do primeiro avião a voar da Embraer,vamos lá?");

            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("O Embraer EMB-110 \"Bandeirante\" foi um avião bimotor turboélice" +
                " destinado ao uso civil e militar, com capacidade para vinte e um passageiros," +
                " desenvolvido" + " e fabricado no Brasil pela Embraer, vou lhe dizer qauntos anos ele tem hoje, beleza?");

            Console.ReadLine();
            
            Subtracao = AnoAtual - 1968;

            Console.WriteLine(" Então o primeiro voo do avião da" +
                " Embraer foi em 1968 e hoje ele tem: " + Subtracao);
            Console.ReadLine();

        }
    }
}
