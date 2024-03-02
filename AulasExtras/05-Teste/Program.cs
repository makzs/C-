using System;

// Diversas funcionalidades de arrays em C#

namespace ConsoleApp1{

    public class Program{

        // ------- Funcoes -------

        // PrintArray uma funcao para escrever na tela o valor de cada array (k) e uma mensagem (mess)
        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        // funcao logica que encontra valores maiores que 10
        static bool GT10(int num) {
            return num > 10;
        }


        // ------- Fim das Funcoes -------

        static void Main(String[] args){

            //cria um array de inteiros chamado favNums com tamanho 3
            int[] favNums = new int[3];
            // declara que o favNums na posicao 0 é igual a 23
            favNums[0] = 23;
            // Escreve na tela "favNum 0: x" onde x é a posicao 0 do array favNums
            Console.WriteLine("favNum 0: {0}", favNums[0]);

            // cria um array de strings chamado clientes
            string[] clientes = {"Bob", "Samantha", "Jorge"};
            // cria um array de var chamado funcionarios
            var funcionarios = new[] {"Mike", "paulo", "Veronica"};

            // cria um objeto que é basicamente um array que comporta varios tipos de dados
            object[] randomArray = {"Paulo", 45, 1.234};
            // Escreve na tela o tipo de dados da posicao 0 do array randomArray
            Console.WriteLine("randomArray 0: {0}",
                randomArray[0].GetType());
            // escreve na tea o tamanho do array randomArray
            Console.WriteLine("Tamanho do array: {0}", randomArray.Length);

            // laço for que escreve na tela a posicao do array e o seu valor
            for(int j = 0; j < randomArray.Length; j++){
                Console.WriteLine("Array : {0} : Valor: {1}", 
                    j, randomArray[j]);
            }

            Console.WriteLine("----------------------------------");

            // cria um array multidimensional em que recebe os valores bob e samuel em colunas e maria e jose em linhas
            string[,] clientesNomes = new string[2, 2] {{"bob", "samuel"}, 
                {"Maria", "Jose" }};
            // escreve na tela o valor da posicao 1, 1 do array clientesNomes
            Console.WriteLine("valor MD: {0}",
                clientesNomes.GetValue(1, 1));

            // laço de repeticao for para escrever na tela cada valor de cada posicao do array clientesNomes
            for(int j = 0; j < clientesNomes.GetLength(0); j++)
            {
                for(int k = 0; k < clientesNomes.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", clientesNomes[j, k]);
                }
                Console.WriteLine();


            }

            // cria um array randomNums
            int[] randomNums = {1, 4, 9, 2};
            // utiliza a funcao printArray para escrever o valor de cada array e uma mensagem
            PrintArray(randomNums, "Numero");

            Console.WriteLine("----------------------------------");

            // metodo para embaralhar valores de um array
            Array.Sort(randomNums);
            // metodo para dar um reverse nos valores de um array
            Array.Reverse(randomNums);
            // metodo indexOf procura a posicao do array onde encontra tal valor, no caso o valor 1
            // nesse caso sempre ira retornar a posicao 3 por causa do reverse logo acima
            Console.WriteLine("1 no index: {0}",
                Array.IndexOf(randomNums, 1));
            // metodo que atribui o valor 0 na posicao 1 do array randomNums
            randomNums.SetValue(0, 1);

            // cria um array source (fonte)
            int[] srcArray = {1, 2, 3};
            // cria um array destiny (destino)
            int[] destArray = new int[2];
            // variavel que indica o indice inicial, no caso 0
            int startInd = 0;
            // variavel que indica o tamanho desejado
            int length = 2;
            // metodo para copiar parte do array para o outro
            // (array que deseja copiar, posicao que deseja começar a copiar, array de destino,
            // posicao para onde vai a copia do array destinado, tamanho que deseja copiar)
            // esse metodo começa no indice indicado mas nao copia ele, ele copia os proximos numeros
            Array.Copy(srcArray, startInd, destArray, 0, length);
            // utiliza a funcao printarray para mostrar na tela junto com a mensagem Copy:
            PrintArray(destArray, "Copy");

            // cria um array anotherArray do tipo int e com 10 valores
            // em seguida copia os valores do srcArray a partir da posicao 5
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            // laço foreach imprime na tela a mensagem "CopyTo :" e o valor de cada array
            // como a copia foi feita a partir da posicao 5, o restante tera valor 0
            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }

            // cria um array numArray
            int[] numArray = {1, 11, 22};
            // utiliza o metodo find e a funcao GT10 para escrever na tela o primeiro
            // valor maior que 10 dentro do array
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

        }
    }
}