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
        // Main   | Método/função nativa do C#
        // Main   | Como método principal é o primeiro a ser executado num programa em C#
        // (string[] args) | Informa que dentro desse metódo temos dados do tipo string/textos 
        // {...}  | Escopo no qual deve ser inserido o bloco de código referente a ser executado pelo método
        static void Main(string[] args)
        {
            //Bloco dde Código do Método Main()


            // DECLARAR VARIÁVEIS
            // Tipo da variavel   | string
            // Nome para variavel | inNome
            // Fim da instrução   | ;
            // tipo nomevariavel fimdainstrução | string inNome;


            // DECLARAR VARIÁVEIS E INICIALIZAR AO RECEBER UM VALOR DE ATRIBUIÇÃO
            // Tipo da variavel    | string
            // Nome para variavel  | inNome
            // Sinal de Atribuição | =
            // Valor               | "Romulo"
            // Fim da instrução    | ;
            // tipo nomevariavel atribuição valor/operação/função fimdainstrução | string inNome = "Rosadev";

            // Declaramos e inicializamos uma variavel pra armazenar e/ou manipular dados
            string inNome = "Romulo";


        }
    }
}
