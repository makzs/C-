using System;

// Estruturas condicionais if / else / else if

namespace ConsoleApp1{

    public class Program{

        // ----------- FUNCOES -----------


        // ----------- FIM FUNCOES -----------

        static void Main(string[] args){

            // Operadores relacionais: > < >= <= == !=
            // Operadores logicos: && || !

            // exemplos de condicionais simples
            int idade = 17;
            if((idade >= 5) && (idade <= 7))
            {
                Console.WriteLine("Criança!");
            }

            if((idade > 7) && (idade < 13))
            {
                Console.WriteLine("Pre-Adolescente!");
            }

            if((idade > 13) && (idade < 19))
            {
                Console.WriteLine("Adolescente!");
            }
            else{
                Console.WriteLine("Adulto!");
            }

            // o operador logico ! é o operador de inversao, ele inverte o valor de uma expressao booleana
            Console.WriteLine("! true = " + (!true));

            // o operador ? é um operador ternario, basicamente uma forma mais simples de escrever uma instrução condicional
            // é como se fosse escrito: condição ? expressãoSeVerdadeira : expressãoSeFalsa
            bool canDrive = idade >= 18 ? true : false;

            switch(idade)
            {
                case 1:
                case 2:
                    Console.WriteLine("Bebê!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Quase criança!");
                    break;
                case 5:
                    Console.WriteLine("pequena Criança");
                    break;
                default:
                    Console.WriteLine("Nenhuma das opcoes");
                    break;
            }

            string name2 = "Ronaldo";
            string name3 = "Ronaldo";
            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Nomes sao iguais!");
            }

        }

    }

}
