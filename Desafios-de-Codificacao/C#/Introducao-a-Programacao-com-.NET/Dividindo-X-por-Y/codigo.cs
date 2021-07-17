/*
Desafio
Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

Entrada
A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

Saída
Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

-----------------------------------------
Exemplo de Entrada      Exemplo de Saída
-----------------------------------------
3                       -1.5
3 -2                    divisao impossivel
-8 0                    0.0
0 8
-----------------------------------------
*/

using System;

class Desafio 
{
    static void Main() 
    {
        int limit = Int32.Parse(Console.ReadLine());
        
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            
            if (Y == 0) 
            {
                Console.WriteLine("divisao impossivel");
            } 
            
            else 
            {
                double divisao = (double)X / Y;; 
                
                if (divisao < 0 && divisao > -0.5)
                {
                  Console.WriteLine("-0.0");
                }
                
                else
                {
                  Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
                }
            }
        }
    }
}