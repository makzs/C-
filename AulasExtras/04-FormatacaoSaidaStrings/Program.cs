using System;

// Formatacao de Strings

namespace ConsoleApp1{

    public class Program{

        static void Main(String[] args){
            // string que vai ser utilizada as funcoes
            string randomString = "This is a string";

            // mostra o tamanho da string
            Console.WriteLine("String lenght: {0}", randomString.Length);
            // verifica se a string contem a palavra "is"
            Console.WriteLine("String contem is: {0}", randomString.Contains("is"));
            // verifica onde contem a palavra "is"
            Console.WriteLine("Index do is: {0}", randomString.IndexOf("is"));
            // remove uma parte da string
            Console.WriteLine("Remover String: {0}", randomString.Remove(10, 6));
            // insere um texto dentro da string
            Console.WriteLine("Inserir String: {0}", randomString.Insert(10, "short "));
            // substitui uma parte da string
            Console.WriteLine("Substituir String: {0}", randomString.Replace("string", "sentence"));
            // compara duas strings:
            // < 0: str1 precede str2
            // = : iguais
            // > 0: str2 precede str1
            Console.WriteLine("Comparar A com B: {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("-------------------------------");

            // verifica se as string sao iguais (utliziando um metodo para ignorar se e maiusculo ou minusculo)
            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // adiciona um pad de tamanho 20 a esquerda, ou seja varios ...
            Console.WriteLine("Pad esquerdo: {0}",
                randomString.PadLeft(20, '.'));
            // adiciona um pad de tamanho 20 a direita, ou seja varios ...
            Console.WriteLine("Pad direito: {0}",
                randomString.PadRight(20, '.'));

            // metodo de formatacao para remover os espacos no inicio e no fim da string
            Console.WriteLine("Trim : {0}",
                randomString.Trim());
            // trasnforma a string em maiscula
            Console.WriteLine("maiuscula : {0}",
                randomString.ToUpper());
            // trasnforma a string em minuscula
            Console.WriteLine("minuscula : {0}",
                randomString.ToLower());

            // uma maneira de escrever uma string e colocar campos variaveis
            string newString = String.Format("{0} viu um {1} {2} no {3}",
                "cachorro", "coelho", "comendo", "campo");
            // \n e um caracter de escape, um entre muitos que realiza uma tarefa especifica
            // por exemplo \n indica para quebrar linha
            Console.Write(newString + "\n");
            // o @ antes da string indica que vai ignorar os caracteres de escape
            Console.WriteLine(@"Exatamente o que eu digitei\n");



        }

    }

}