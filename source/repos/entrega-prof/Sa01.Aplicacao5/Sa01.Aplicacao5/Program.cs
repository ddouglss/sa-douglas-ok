using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara a variaveis
            decimal jan, fev, mar, media;
            //entrada de dados
            jan = 1000;
            fev = 2000;
            mar = 3000;
            //processamneto de dados
            media = (jan + fev + mar) / 3;
            //saida de dados
            Console.WriteLine(media);
            //para a tela
            Console.ReadLine();
        }
    }
}
