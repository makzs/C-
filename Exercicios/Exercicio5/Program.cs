//Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. 
//Por exemplo: caso o usuário insira o número 15, o programa deve imprimir 
// na tela os números 0, 1, 1, 2, 3, 5, 8, 13.

// variaveis
int x = 0;
int y = 1;

// recebe o valor limite
Console.WriteLine("Informe o valor que deseja definir como limite: ");
int valor = System.Convert.ToInt32(Console.ReadLine());

// escreve o primeiro valor da sequencia
Console.Write(x);

// imprime a sequencia de fibonacci
// z e uma variavel temporaria para guardar o valor de x+y antes de alteralos
while (y <= valor) {
    Console.Write(" " + y);

    int z = x+y;
    x = y;
    y = z;

}
