/*
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

-----------------------------------------------------------------
Exemplo de Entrada                              Exemplo de Saída
-----------------------------------------------------------------
4                                               encaixa
56234523485723854755454545478690 78690          nao encaixa
5434554 543                                     encaixa
1243 1243                                       nao encaixa
54 64545454545454545454545454545454554
-----------------------------------------------------------------
*/

import java.io.IOException;
import java.util.Scanner;

public class Codigo {

	public static void main(String[] args) throws IOException 
	{
		Scanner leitor = new Scanner(System.in);
		
		int N = leitor.nextInt();

		for (int i = 0; i < N; i++) 
		{
			String A = leitor.next();
			String B = leitor.next();
			if (A.endsWith(B))  
				System.out.println("encaixa");
			else 
				System.out.println("nao encaixa");
		}
	}

}