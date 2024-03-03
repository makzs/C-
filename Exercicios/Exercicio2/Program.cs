/* 
Exercicio 02
Crie um algoritmo que permita fazer três conversões monetárias. 
O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
1. Dólar (1 dólar = 5,17 reais)
2. Euro (1 euro = 6,14 reais)
3. Peso argentino (1 peso argentino = 0,05 reais)
*/

// Variaveis:
double dolar, euro, peso;

// Resolução

// Le o valor em reais. O comando parse é para converter a string no tipo float
Console.WriteLine("Informe o valor que deseja converter: ");
double valor = System.Convert.ToDouble(Console.ReadLine());

// converte o valor em reais para os respectivos preços
dolar = valor / 5.17f;
euro = valor / 6.14f;
peso = valor / 0.05f;

Console.WriteLine($"O valor {valor:c} convertido em ");
Console.WriteLine($"Dolar: {dolar:c}");
Console.WriteLine($"Euro: {euro:c}");
Console.WriteLine($"Peso Argentino: {peso:C}");