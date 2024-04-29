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

            // SAÍDA DE DADOS
            // Console.WriteLine(parametro);  |  Elemento atribuição metodo(parametro) fimdainstrução
            // Console     | Elemento
            // .           | Forma de atribuir um método a um elemento
            // WriteLine   | Método pra realizar saída de dados. Recurso do namespace System.
            // (parametro) | O que desejamos que seja exibido como saída de dados
            // ;           | Fim da instrução

            // CONCATENAÇÃO DE TEXTOS E VARIAVEIS
            // ("texto " + nomevariavel + "texto " + nomevariavel)

            // CONCATENAÇÃO USANDO INTERPOLAÇÃO DE STRINGS
            // Forma mais atual usada concatenar dados string com variaveis
            // ($"texto {variavel} texto {inSobrenome}")






            // Declaramos e inicializamos uma variavel pra armazenar e/ou manipular dados
            string inNome = "Romulo";
            string inSobrenome = "Rosa";

            // Exibimos os dados no console interpolação de strings
            Console.WriteLine($"NOME: {inNome} | SOBRENOME: {inSobrenome}");







        }
    }
}
