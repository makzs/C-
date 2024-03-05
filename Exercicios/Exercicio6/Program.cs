// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
// 1. Desenvolver o algoritmo de ordenação (Bubble Sort);
// 2. Utilizar uma função em C# para ordenação;

public class Program{

    // ---------- FUNCOES ----------

    // Funcao Bubble Sort
    public static void BubbleSort(int[] array){

        // primeiro laço para garantir que vai percorrer quantas vezes for necessario para verificar tudo
        for (int i = 0; i < array.Length - 1; i++ ){
            // segundo laço for que vai percorrer todos os caracteres
            for(int j = 0; j < array.Length - i - 1; j++){
                // se a posicao menor tiver um valor maior ela vai trocar de lugar
                if(array[j] > array[j+1]){
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }

    // ---------- FIM FUNCOES ----------


    public static void Main(String[] args){

        // cria um array de 1000 posicoes
        int[] arrayVal = new int[1000];
        // cria um objeto "random" utilizando a classe Random
        Random random = new Random();

        // laço de repetição para aleatorizar os valores
        for (int i = 0; i < 1000; i++){

            arrayVal[i] = random.Next(1000);

        }

        // Imprime na tela os valores randomizados;
        Console.WriteLine("Numeros Randomizados: ");
        for (int i = 0; i < 1000; i++){

            Console.Write("- " + arrayVal[i] + " -");

        }

        Console.WriteLine("------------------------");

        // Imprime na tela os valores que foram ordenados pela funcao
        Console.WriteLine("Numeros ordenados por BubbleSort: ");
        BubbleSort(arrayVal);
        for (int i = 0; i < 1000; i++){

            Console.Write("- " + arrayVal[i] + " -");

        }


    }

}