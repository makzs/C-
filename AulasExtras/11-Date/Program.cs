using System;

// Tipos DateTime e TimeSpan
// Tipos Enumerados

namespace ConsoleApp1{

    public class Program{

        // ---------- Funcoes ----------
        
        // cria uma funcao chamada paintcar em que fala a cor e o codigo em que o carro foi pintado
        // cc e uma abreviacao do parametro
        static void PaintCar(CarColor cc){
            Console.WriteLine("O carro foi pintado {0} com o codigo {1}", cc, (int)cc);

        }


        // ---------- Fim Funcoes ----------

        // enumerated type, tipo enumerado
        // define uma lista de cores e que sequencia de numeros ela vai seguir
        // retorna tipo byte mas pode ser outros tipos como int
        enum CarColor : byte{
            orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }


        static void Main(string[] args){

            // DateTime e TimeSpan

            // Cria uma variavel MelhorData de tipo DateTime que se comporta como um objeto e armazena datas
            DateTime MelhorData = new DateTime(2003, 12, 29);
            // imprime na tela o dia da semana da data armazenada
            Console.WriteLine("Dia da semana: {0}", MelhorData.DayOfWeek);

            // adiciona 4 dias na variavel
            MelhorData = MelhorData.AddDays(4);
            // adiciona 1 mes na variavel
            MelhorData = MelhorData.AddMonths(1);
            // adiciona 1 ano na variavel
            MelhorData = MelhorData.AddYears(1);

            // Escreve a nova data que esta na variavel
            Console.WriteLine("Nova Data: {0}", MelhorData.Date);

            // Cria uma variavel lunchtime de tipo TimeSpan que se comporta como um objeto e armazena horarios
            TimeSpan lunchtime = new TimeSpan(12, 30, 0);
            // Diminui 15 minutos da variavel
            lunchtime = lunchtime.Subtract(new TimeSpan(0, 15, 0));

            // escreve o novo tempo da variavel lunchtime
            Console.WriteLine("Novo tempo: {0}", lunchtime.ToString());

            Console.WriteLine("----------------------------------");

            // tipos enumerados

            // car1 recebe a cor blue
            CarColor car1 = CarColor.Blue;
            // chama a funcao paintcar para imprimir a cor e o codigo do car1
            PaintCar(car1);

        }

    }

}