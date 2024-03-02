using System;

// Conceitos Basicos de Terminal

namespace ConsoleApp1{

    public class Program{
        static void Main(String[] args){

            // altera a cor das letras do terminal
            Console.ForegroundColor = ConsoleColor.Black;
            // altera o cor de fundo do terminal
            Console.BackgroundColor = ConsoleColor.White;
            // da um clear no terminal
            Console.Clear();

            // write  diferente do write line, ele aceita o input ser na mesma linha
            Console.WriteLine("What is your name? ");
            // input para receber a variavel string nome
            string nome = Console.ReadLine();
            // escreve no terminal a mensagem com a variavel no meio
            Console.WriteLine($"Hello {nome}");
        }
    }
}