using System;

// While e Do while

namespace ConsoleApp1{

    public class Program{

        // ---------- Funcoes ----------


        // ---------- Fim funcoes ----------

        static void Main(String[] args){
            
            // cria um contador
            int i = 1;
            // loop que imprime numero impares ate o 10 (fora o 9)
            while(i <= 10)
            {
                if(i % 2 == 0){
                    i++;
                    continue;
                }
                if(i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("-----------------------------");

            // cria uma variavel randomica
            Random rnd = new Random();
            // armazena um numero aleatorio entre 1 a 11
            int numSecreto = rnd.Next(1, 11);
            int numPalpite = 0;

            // laço de repetição do while, ele executa pelo menos uma vez ao contrario do while
            do
            {
                Console.WriteLine("Pensei em um numero...");
                Console.WriteLine("De um palpite de 1 a 10: ");
                numPalpite = Convert.ToInt32(Console.ReadLine());

            } while(numSecreto != numPalpite);

            Console.WriteLine("Parabens voce adivinhou o numero que pensei! foi o numero {0}", numSecreto);


        }

    }

}