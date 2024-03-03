/* 
Exercicio 01
Escreva um algoritmo que receba a altura e a largura de um retangulo e calcule a sua area
*/

// Variaveis
int area;

Console.Write("Calculadora de Area de Retangulos \n");

// Pergunta a altura do retangulo
Console.Write("Informe a altura do retangulo: ");
int altura = System.Convert.ToInt32(Console.ReadLine());

// Pergunta a largura do retangulo
Console.Write("Informe a largura do retangulo: ");
int largura = System.Convert.ToInt32(Console.ReadLine());

// Calcula a area do retangulo
area = altura * largura;

// Mostra o calculo da area do retangulo
Console.WriteLine($"A area desse retangulo é de: {area}!");
