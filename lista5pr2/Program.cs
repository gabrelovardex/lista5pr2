
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista5pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("valor: " + i);
            //}

            //Console.ReadKey();

            //------------------------------------------------------------------

            //int N;

            //Console.WriteLine("Entre com um número: ");
            //N = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine("valor de i: " + i);   
            //}

            //Console.ReadKey();

            //------------------------------------------------------------------

            //int n;

            //Console.WriteLine("Entre com um número: ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = n; i > 0; i--)
            //{
            //    Console.WriteLine("valor de i: " + i);   
            //}

            //Console.ReadKey();

            //------------------------------------------------------------------

            int menu;

            Console.WriteLine("Escolha um dos exercícios: ");

            Console.WriteLine(" EXERCÍCIO - 1");
            Console.WriteLine(" EXERCÍCIO - 2");
            Console.WriteLine(" EXERCÍCIO - 3");
            Console.WriteLine(" EXERCÍCIO - 4");
            Console.WriteLine(" EXERCÍCIO - 5");
            Console.WriteLine(" EXERCÍCIO - 6");
            Console.WriteLine(" EXERCÍCIO - 7");

            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:

                    int n, i;

                    Console.WriteLine("entre com um número: ");
                    n = int.Parse(Console.ReadLine());

                    for ( i = 1; i <= n; i++)
                    {
                        Console.WriteLine("valor de i: " + i);
                    }
                    break;

                case 2:

                    int N, i;

                    Console.WriteLine("entre com um número: ");
                    N = int.Parse(Console.ReadLine());

                    for ( i = 1; i <= N; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine("valor de i: " + i);


                    }
                    break;

                case 3:

                    int numero, i;

                    Console.WriteLine("entre com um número : ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 1000)
                        for ( i = 1000; i > numero; i--)
                        {
                            if (i % 2 == 0)
                                Console.WriteLine("valor de i: " + i);
                        }
                    else
                        Console.WriteLine("número inválido");
                    break;

                case 4:

                    int number, soma;

                    Console.WriteLine("entre com um número : ");
                    number = int.Parse(Console.ReadLine());


                    for (soma = 0; soma <= 200;)
                    {


                        if (number > 0)
                            soma = soma + number;


                        else
                            Console.WriteLine("NÚMERO INVÁLIDO");
                     }



                    break;

                case 5:


                    int i, valornum;

                    Console.WriteLine("entre com um numero: ");
                    valornum = int.Parse(Console.ReadLine());

                    for(i = 1; i <= valornum; i++)
                    {
                       if(valornum %i == 0)
                       {
                           Console.WriteLine("É divisível por: " + i);
                       }
                    }

                    break;

                case 6:

                    int n;

                    Console.WriteLine("Entre com um número: ");
                    n = int.Parse(Console.ReadLine());
                    for (int i = n; i > 0; i--)
                    {
                        Console.WriteLine("valor de i: " + i);
                    }

                    Console.ReadKey();

                    break;

                case 7:


                    int N;

                    Console.WriteLine("Entre com um número: ");
                    N = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= N; i++)
                    {
                        Console.WriteLine("valor de i: " + i);
                    }

                    Console.ReadKey();

                    break;


            }

            Console.ReadKey();
        }
    }
}
