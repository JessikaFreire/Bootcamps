/*
Desafio
Há um país denominado Lolipad, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Loli, cujo símbolo é o R$.

Você terá o desafio de ler um valor com duas casas decimais, equivalente ao salário de uma pessoa de Loli. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

Renda                       Imposto de Renda
de 0.00 a 2000.00           Isento
de 2000.01 até 3000.00      8%
de 3000.01 até 4000.00      18%
acima de 4500.00            28%

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima o texto "R$" seguido de um espaço e do valor total devido de Imposto de Renda, com duas casas após o ponto. Se o valor de entrada for menor ou igual a 2000, deverá ser impressa a mensagem "Isento".

---------------------------------------------- 
Exemplos de Entrada	        Exemplos de Saída
---------------------------------------------- 
3002.00                     R$ 80.36
---------------------------------------------- 
1701.12                     Isento
---------------------------------------------- 
4520.00                     R$ 355.60
---------------------------------------------- 
*/

let salario = gets();

function calcularImposto(valor) {

  let imposto = 0;
  let montante;
  let salario = valor;

    if (valor > 4500) {
    imposto = 1000 * 0.08 + 1500 * 0.18
    montante = valor - 4500
    imposto += montante * 0.28
  } else if (valor > 3000) {
    imposto = 1000 * 0.08
    montante = valor - 3000
    imposto += montante * 0.18
  } else if (valor > 2000) {
    montante = valor - 2000
    imposto = montante * 0.08
  }
  
    return imposto;

}

let resultado = calcularImposto(salario);

print((resultado == 0.0)? "Isento" : "R$ "+resultado.toFixed(2));