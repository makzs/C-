/*
A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que a entrada seja uma representação válida de um inteiro.
Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.
*/

/*
string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Entre com um valor entre 5 e 10:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (numericValue > 5 && numericValue < 10){
            validNumber = true;
        }
        else{
            Console.WriteLine("Informe um valor entre 5 e 10!");
            validNumber = false;
        }
        if (validNumber == false)
        {
            Console.WriteLine("Tente novamente: ");
        }
    }

} while (validNumber == false);

*/