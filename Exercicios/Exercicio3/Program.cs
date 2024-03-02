/*
Exercicio 03
Receber dois numeros inteiros e informar qual valor lido é o menor e qual é o maior.
*/

// Variaveis
int x, y;

// primeiro valor
Console.WriteLine("Informe o primeiro valor: ");
x = int.Parse(Console.ReadLine());

// segundo valor
Console.WriteLine("Informe o segundo valor: ");
y = int.Parse(Console.ReadLine());

// condicionais
if(x > y){
    Console.WriteLine($"O numero {x} é maior que o numero {y}");

}

else{
    Console.WriteLine($"O numero {y} é maior que o numero {x}");
}