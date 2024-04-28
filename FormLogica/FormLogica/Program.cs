// using é uma instrução com caratér de chamar algo a uso
// System é um namespace que disponibiliza diversos recursos para desenvolvimento
// Ex.: Funções de Entrada e Saída de Dados como .ReadLine() e .WriteLine()
using System;


// namespace nomeprojeto
// Toda logica referente ao programa precisa estar dentro desse escopo/par de chaves
namespace FormLogica
{
    class Program
    {

        // static | Informa ser uma função estática
        // void   | Informa ser também uma função sem retorno
        // Main() | Método/função nativa do C#
        // Main() | Como método principal é o primeiro a ser executado num programa em C#
        // Main() | O bloco de código dentro de seu escopo é o primeiro a ser executado
        // (string[] args) | Informa que dentro desse metódo temos textos 
        static void Main(string[] args)
        {
            //Bloco de Código do Main
            Console.WriteLine("Hello World!");
        }
    }
}
