/*
Exercicio 03
Receber dois numeros inteiros e informar qual valor lido é o menor e qual é o maior.
*/

// primeiro valor
Console.WriteLine("Informe o primeiro valor: ");
int x = System.Convert.ToInt32(Console.ReadLine());

// segundo valor
Console.WriteLine("Informe o segundo valor: ");
int y = System.Convert.ToInt32(Console.ReadLine());

// condicionais
if(x > y){
    Console.WriteLine($"O numero {x} é maior que o numero {y}");

}

else{
    Console.WriteLine($"O numero {y} é maior que o numero {x}");
}