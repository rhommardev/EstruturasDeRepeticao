// See https://aka.ms/new-console-template for more information
using System;

//usando FOR

int numero = 1;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

//usando WHILE


int numero2 = 2;
int contador2 = 0;

while (contador2 <= 10)
{
    Console.WriteLine($"{contador2} execucao : {numero2} x {contador2} = {numero2 * contador2}");
    contador2++;
}


