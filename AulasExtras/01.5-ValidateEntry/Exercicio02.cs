/*
A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço de entrelinhamento e à direita.
A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.
*/

/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Informe sua função: (Administrador Gerente ou Usuário.)");
do
{
    readResult = Console.ReadLine()?.Trim().ToLower();
    if (readResult != null){
        switch (readResult){
            case "administrador":
            Console.WriteLine("A função Administrador foi reconhecida!");
            validEntry = true;
            break;
            case "gerente":
            Console.WriteLine("A função Gerente foi reconhecida!");
            validEntry = true;
            break;
            case "usuario":
            Console.WriteLine("A função Usuario foi reconhecida!");
            validEntry = true;
            break;
            default:
            Console.WriteLine($"Função {readResult} é desconhecida! por favor insira um valor valido");
            break;
        }
    }
} while (validEntry == false);
*/