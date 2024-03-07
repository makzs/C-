//

// cria um vetor de 1000 posicoes
int[] vetor = new int[1000];

// cria um objeto de tipo random
Random random = new Random();

// vetor recebe os valores random
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);

}

Console.WriteLine("Valores Aleatorios:\n");

// imprime na tela os valores randomicos
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " - ");
}

Console.WriteLine("\n\n- - - - - - - - - - - - - - - -\n");
Console.WriteLine("Valores Ordenados:");


// Algoritimo de ordenação bubble sort
for (int i = 0; i < vetor.Length - 1; i++){
    for (int j = 0; j < vetor.Length - i - 1; j++)
    {
        if (vetor[j] > vetor[j+1])
        {
            int temporario = vetor[j];
            vetor[j] = vetor[j+1];
            vetor[j+1] = temporario;
        }
    }
}

// imprime na tela os valores randomicos ordenados pelo bubble sort
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " - ");
}