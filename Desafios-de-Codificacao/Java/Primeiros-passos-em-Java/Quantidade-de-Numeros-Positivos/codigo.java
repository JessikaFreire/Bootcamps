/*
Desafio
Crie um programa que leia 6 valores. Você poderá receber valores negativos e/ou positivos como entrada, devendo desconsiderar os valores nulos. Em seguida, apresente a quantidade de valores positivos digitados.

Entrada
Você receberá seis valores, negativos e/ou positivos.

Saída
Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída. Não esqueça da mensagem "valores positivos" ao final.

-------------------------------------------
Exemplo de Entrada		Exemplo de Saída
-------------------------------------------
7 						4 valores positivos
-5
6
-3.4
4.6
12
-------------------------------------------
*/

import java.io.IOException;
import java.util.Scanner;

public class Desafio {

  public static void main(String[] args) throws IOException {

    Scanner leitor = new Scanner(System.in);

    double x;
    int cont = 0;
    int qtd = 0;

    for(int i = 0; i<6; i++)
    {
		x = leitor.nextDouble();

     	if (x > 0)
     	{
      		qtd ++;
     	}
    }
    System.out.println(qtd + " " + "valores positivos");
  }
}