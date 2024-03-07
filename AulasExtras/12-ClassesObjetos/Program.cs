using System;
using System.Security.Cryptography;

// Classes / objetos / structs

namespace _12_ClassesObjetos{

    public class Program{

        static void Main(String[] args){

            // define uma variavel do tipo Retangulo (criado em struct)
            Retangulo rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area do rect1: {0}", rect1.Area());

            Retangulo rect2 = new Retangulo(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}", rect2.length);

        // instancia um objeto da classe Animal
        Animal raposa = new Animal()
        {
            name = "Red",
            sound = "Raaw"
        };

        Console.WriteLine("# of Animals {0}",
            Animal.GetNumAnimals());

        // utiliza a classe ShapeMath
        Console.WriteLine("Area do Retangulo: {0}",
            ShapeMath.GetArea("Retangulo", 5, 6));

        }

        // cria a struct retangulo
        struct Retangulo
            {
                // pede dois valores, o comprimento e a largura
                public double length;
                public double width;

                public Retangulo(double l = 1, double w = 1){ length = l; width = w; }

                // retorna a area do retangulo
                public double Area()
                {
                    return length * width;
                }
            }

    }

}