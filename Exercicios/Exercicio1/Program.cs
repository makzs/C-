/* 
Exercicio 01
Escreva um algoritmo que receba a altura e a largura de um retangulo e calcule a sua area
*/

// Variaveis
float altura, largura, area;

Console.WriteLine("Calculadora de Area de Retangulos \n");

// Pergunta a altura do retangulo
Console.WriteLine("Informe a altura do retangulo: ");
altura = float.Parse(Console.ReadLine());

// Pergunta a largura do retangulo
Console.WriteLine("Informe a largura do retangulo: ");
largura = float.Parse(Console.ReadLine());

// Calcula a area do retangulo
area = altura * largura;

// Mostra o calculo da area do retangulo
Console.WriteLine($"A area desse retangulo é de: {area}!");
