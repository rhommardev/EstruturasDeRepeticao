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

//interrumpiendo  el lazo while usando break

int numero3 = 2;
int contador3 = 0;

while (contador3 <= 10)
{
    Console.WriteLine($"{contador3} execucao : {numero3} x {contador3} = {numero2 * contador3}");
    contador3++;

    if (contador3 == 5)
    {
        Console.WriteLine("Interrumpiendo el lazo while");
        break;
    }

}