using System;

// Tratamento de erros e excecoes 

namespace ConsoleApp1{

    public class Program{

        // ----------- FUNCOES -----------

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        // ----------- FIM FUNCOES -----------

        static void Main(String[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }

            catch (DivideByZeroException ex){
                Console.WriteLine("Voce nao pode dividir por 0");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex){
                Console.WriteLine("Erro ocorreu");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally{
                Console.WriteLine("Limpando...");
            }

        }

    }


}