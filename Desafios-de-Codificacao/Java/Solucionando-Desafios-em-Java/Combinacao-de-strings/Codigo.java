/*
Desafio
Crie um algoritmo que receba dois inputs que sejam strings e combine-as alternando as letras de cada string. 

Deve começar pela primeira letra da primeira string, seguido pela primeira letra da segunda string, em seguida pela segunda letra da primeira string e continuar dessa forma sucessivamente.

As letras restantes da cadeia mais longa devem ser adicionadas ao fim da string resultante e retornada.

Entrada
A entrada contém vários casos de teste. A primeira linha contém um inteiro N que indica a quantidade de casos de teste que vem a seguir. Cada caso de teste é composto por uma linha que contém duas cadeias de caracteres, cada cadeia de caracteres contém entre 1 e 50 caracteres inclusive.

Saída
Combine as duas cadeias de caracteres da entrada como mostrado no exemplo abaixo e exiba a cadeia resultante.

----------------------------------------
Exemplo de Entrada      Exemplo de Saída
----------------------------------------
2                       aBAb
aA Bb                   abab
aa bb
----------------------------------------
*/

import java.util.Scanner;

public class Desafio {

	public static void main(String[] args) 
	{
		Scanner leitor = new Scanner(System.in);
		
		int N = Integer.parseInt(leitor.nextLine());
		
		for (int i = 0; i < N; i++) 
		{
			
			StringBuilder resultado = new StringBuilder();
      String[] cadeia = leitor.nextLine().split(" ");
        
      int maxSize = Math.max (     
      cadeia[0].length(),
      cadeia[1].length());
            
            
			for (int j = 0; j < maxSize; j++) 
			{
			  
			  if(j < cadeia[0].length()) 
			  {
          resultado.append(cadeia[0].charAt(j));
        }
        
        if(j < cadeia[1].length()) 
        {
          resultado.append(cadeia[1].charAt(j));
        }
			}
			System.out.println(resultado.toString());
		}
	}

}