using System;

// Funcoes / Access Specifier / Out Parameter / numero de parametros desconhecido / metodo overloading

namespace ConsoleApp1{

    public class Program{

        // ----------- Funcoes -----------
        // <Access Specifier> <Return Type> <Method Name>(Parameters)
        // { <Body> }

        // Access Specifier determina se a funcao pode ser chamada por outra classe
        // public : Pode ser acessada por outra classe
        // private : Nao pode ser acessada por outra classe
        // protected : Nao pode ser acessada por outra classe mas pode ser acessada por classes derivadas

        // O QUE ACONTECE NA FUNCAO FICA NA FUNCAO

        // funcao padrao
        private static void DizOla(){
            string nome = "";
            Console.Write("Qual é o seu nome : ");
            nome = Console.ReadLine() ?? "";
            Console.WriteLine("Ola {0}", nome);
        }

        // funcao padrao, com retorno
        static double Soma(double x = 1, double y =1){
            return x + y;
        }

        // funcao out parameter (passa informacoes da funcao direto para o chamador da funcao)
        static void DoubleIt(int x, out int solution){
            solution = x * 2;
        }

        // funcao pass by reference (pega uma referencia do chamador e utiliza dentro da funcao)
        public static void Swap(ref int num3, ref int num4){
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // funcao de numero de parametros desconhecido. utilizando array se pode ter inumeros parametros
        static double SomaMais(params double[] nums){
            double sum = 0;
            foreach(int i in nums){
                sum += i;
            }
            return sum;
        }

        // funcao padrao mas o chamador que define dentro da instrucao qual e o valor dos campos
        static void PrintInfo(string nome, int CEP){
            Console.WriteLine("{0} vive no CEP: {1}", nome, CEP);
        }

        // Metodo overloading onde se cria duas funcoes de nome igual porem que trabalham com tipos diferentes
        static double SomaMelhorada(double x = 1, double y = 1){
            return x + y;
        }
        static double SomaMelhorada(string x = "1", string y = "1"){
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }


        //  ----------- Fim Funcoes -----------

        static void Main(String[] args){

            int solution;

            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            Console.WriteLine("----------------------");

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Antes da troca -> num1: {0} num2 : {1}",
                num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("Depois da troca -> num1: {0} num2 : {1}", num3, num4);

            Console.WriteLine("----------------------");

            Console.WriteLine("1+2+3 = {0}",
                SomaMais(1, 2, 3));

            Console.WriteLine("----------------------");

            PrintInfo(CEP: 123123, nome: "Joao Silva");

            Console.WriteLine("----------------------");

            Console.WriteLine("5.0 + 4.5 = {0}", SomaMelhorada(5.0, 4.5));
            Console.WriteLine("5.0 + 4.5 = {0}", SomaMelhorada("5.0", "4.5"));


        }

    }


}