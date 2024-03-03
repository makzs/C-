﻿/*
Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: 
se idade <= 13: Criança 
se idade > 13 e <= 18: Adolescente 
se idade > 18 e <= 60: Adulto 
se idade > 60: Idoso.
*/

// Recebe a idade
Console.WriteLine("Informe a idade: ");
int idade = System.Convert.ToInt32(Console.ReadLine());

// condicionais para verificar qual resposta dar
if(idade <= 13) {
    Console.WriteLine("Criança!");
}
else if(idade > 13 && idade <= 18){
    Console.WriteLine("Adolescente");
}
else if(idade > 18 && idade <= 60){
    Console.WriteLine("Adulto!");
}
else if(idade > 60){
    Console.WriteLine("Idoso!");
}
else{
    Console.WriteLine("Idade Invalida");
}
