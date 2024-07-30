using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cor = "verde";

            switch(cor){
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelha");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;

                default:
                    Console.WriteLine("sua cor nao foi encontrada");
                    break;

            }


            Console.ReadLine();

        }



    }
}
