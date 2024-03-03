using System;
using System.Globalization;
using System.Text;

// Cadeia de string / string builder

namespace ConsoleApp1{

    public class Program{

        static void Main(String[] args){
            // cria um StringBuilder, um metodo de concatenar strings de uma maneira mais eficiente
            StringBuilder sb = new StringBuilder("Texto Aleatorio");
            StringBuilder sb2 = new StringBuilder("Mais coisas importantes aqui", 256);
            // checa a capacidade de armazenamento do stringbuilder
            Console.WriteLine("Capacidade: {0}", sb2.Capacity);
            // checa o tamanho do stringbuilder
            Console.WriteLine("length: {0}", sb2.Length);

            // da um append nas string, ou sej concatena (o caracter de escape \n faz com que se quebre a linha)
            sb2.AppendLine("\nMais Qualquer Texto");

            // cria um objeto para a cultura especifica
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            // cria a variavel string joao silva e da um apend para concatenar ela
            string MelhorCliente = "joao Silva";
            sb2.AppendFormat(enUS, "Melhor Cliente : {0}", MelhorCliente);
            Console.WriteLine(sb2.ToString());

            // substitui todas as ocorrencias "Texto" para "caracteres" no stringbuilder
            sb2.Replace("Texto", "caracteres");
            Console.WriteLine(sb2.ToString());

            // da um clear no stringbuilder e volta o original
            sb2.Clear();
            sb2.Append("Texto legal");

            // verifica se os stringbuilder sb e sb2 sao iguais e responde como true ou false
            Console.WriteLine(sb.Equals(sb2));

            // insere na posicao 5 a string "isso e otimo"
            sb2.Insert(5, "isso e otimo");
            Console.WriteLine(sb2.ToString());

            // remove 2 caracteres comecando da posicao 5
            sb2.Remove(5, 2);
            Console.WriteLine(sb2.ToString());



        }

    }

}