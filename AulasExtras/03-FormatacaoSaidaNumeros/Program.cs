using System;

// Formatação de saida basica, como manipular a forma em que vai sair o resultado de numeros

namespace ConsoleApp1{

    public class Program{

        static void Main(String[] args){

            // usado para dinheiro, transforma o numero com 2 casas decimais e virgula
            Console.WriteLine("Moeda: {0:c}", 23.455);
            // utilizado para aparecer tamanha quantidade de 0 presente no numero
            Console.WriteLine("Bloco de 0s: {0:d4}", 23);
            // utilizado para escolher quantas casas decimais mostrar
            Console.WriteLine("3 decimais: {0:f3}", 23.455555);
            // utilizado para colocar a virgula em determinado tamanho do numero
            Console.WriteLine("Virgulas: {0:n4}", 2300);

        }

    }

}