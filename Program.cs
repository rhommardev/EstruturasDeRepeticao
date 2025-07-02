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

//usando DO WHILE
//su verificacion sera ejecutada al finaly en el bloque DO ejecutara independientemente de la condicion

int numero4 = 3;
int contador4 = 0;

do
{
    Console.WriteLine($"{contador4} execucao : {numero4} x {contador4} = {numero4 * contador4}");
    contador4++;
} while (contador4 <= 10);




//SEGUNDO EXEMPLO DO WHILE

int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um numro (0 para sair): ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero; //este operador é equivalente a soma = soma + numero;

} while (numero != 0);

Console.WriteLine($" Total da soma dos numeros digitados é: {soma}");



