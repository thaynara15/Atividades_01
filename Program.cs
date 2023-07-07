using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////[Exercício 01]
            //string nome, sobrenome;
            ////Entrada de dados
            //Console.Write("Informe o seu nome: ");
            //nome = Console.ReadLine();

            //Console.Write("Informe o seu sobrenome: ");
            //sobrenome = Console.ReadLine();

            ////Console.Clear();//Limpa o conteúdo da tela

            //Console.WriteLine("Primeiro nome: " + nome);
            //Console.WriteLine("Segundo nome:" + sobrenome);

            //Console.ReadKey();

            int n1, n2;

            Console.Write("Informe um número: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Informe outro número: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n"); // Quebra uma linha

            Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));
            Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
            Console.WriteLine(n1 + " * " + n2 + " = " + (n1 * n2));
            Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));
            

            Console.ReadKey();
        }
    }
}
