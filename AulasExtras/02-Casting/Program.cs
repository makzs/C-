using System;

// Casting, conceito de converter tipos de dados. tanto de um tipo de dado de tamanho maior para um menor
// tanto de tipos de dados de um tamanho menor para um maior

namespace ConsoleApp1{

    public class Program{

        static void Main(string[] args){

            // Casting converter tipos de dados para outros
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();
            Console.WriteLine($"tipo de dado: {strVal.GetType()}");

            // tipo de dado maior convertendo para um menor, perda de dados
            double dblNum = 12.345;
            Console.WriteLine($"Inteiro: {(int)dblNum}");

            // tipo de dado menor convertendo para um maior, sem perda de dados
            int intNum = 10;
            long longNum = intNum;
            
        }

    }

}