using System;
using System.Globalization;

namespace Vetores.Udemy
{
    class Program
    {
        static void Main(string[] args)
        { 
            Vetores[] vetor = new Vetores[10]; //declaração que o vetor tem 10 posições "quartos

            Console.Write("Quantos quartos serão alugados? ");
            int q = int.Parse(Console.ReadLine()); //Dos 10, quantos serão alugados?           

            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine($"Dados do quarto #{i}: ");
                Console.WriteLine("Informe o nome do hóspede: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o email do hóspede: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Vetores(nome, email);}
                
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }

            Console.ReadLine();
        }
    }
}

            