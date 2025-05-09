// See https://aka.ms/new-console-template for more information
using Aula01._1bil;
using System.Runtime.InteropServices;
using System.Timers;

int num1 = 20;
int num2 = 22;
SomaDoisNumeros somador = new SomaDoisNumeros();
int resultado = somador.Somar(num1, num2);
Console.WriteLine($"a soma e {num1} e {num2} da {resultado}");

Console.WriteLine("excreva meno, o tamanho(m): ");
int metros = int.Parse(Console.ReadLine());
MtoMm converta = new MtoMm();
int milimetros = converta.converter(metros);
Console.WriteLine($"{metros}m e ingual a {milimetros}");

bool continuar = true;
while( continuar)
{
    Console.WriteLine("//menu/\n");
    Console.WriteLine("\nescolha uma opção:\n");
    Console.WriteLine("0 - sair");
    Console.WriteLine("1 - somar 2 numeros");
    Console.WriteLine("2 - converter metros(m) para mm");
    Console.WriteLine("3 - ");
    int opcao = int.Parse(Console.ReadLine());
    switch(opcao)
    {
        case 0:
            Console.WriteLine("saindo...");
            continuar = false;
            break;
            case 1:
            Console.WriteLine("escreva 2 numeros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            SomaDoisNumeros somador = new SomaDoisNumeros();
            int resultado

    }
}


/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
