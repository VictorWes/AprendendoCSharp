using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIniciando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subutração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");


            int operacao = int.Parse(Console.ReadLine());
            if (operacao == 0 || operacao >5)
            {
                Console.WriteLine("Olha ai mano escreve direito");
                
            }

            Console.WriteLine("Digite o primeiro numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segund número");
            int num2 = int.Parse(Console.ReadLine());


            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                    case 3:
                    {
                        resultado = Multiplicar(num1, num2);
                        break;
                    }

                    case 4:
                    {
                        resultado = Dividir(num1, num2);
                        break;
                    }
                    default: {
                        Console.WriteLine("Por gentileza forneça um número valido");
                            break; }
            }

            Console.WriteLine($"A operação foi feita da seguimente forma {num1} e {num2} resultado é {resultado}");

            Console.ReadLine();
        }








        public static int Adicao(int numero1, int numero2)
        {

            int result = numero1 + numero2;
            return result;

        }


        public static int Subtracao(int numero1, int numero2)
        {

            int result = numero1 - numero2;
            return result;

        }

        public static int Multiplicar(int numero1, int numero2)
        {

            int result = numero1 * numero2;
            return result;

        }

        public static int Dividir(int numero1, int numero2)
        {

            int result = numero1 / numero2;
            return result;

        }

    }

  
}
