/*
A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci. Nessa sequência, cada número, depois dos 2 primeiros, é igual à soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 46).

Saída
Os valores devem ser mostrados na mesma linha, separados por um espaço em branco. Não deve haver espaço após o último valor.

----------------------------------------
Exemplo de Entrada      Exemplo de Saída
----------------------------------------
5                       0 1 1 2 3
----------------------------------------
*/

var i;
var fib = []; 

fib[0] = 0;
fib[1] = 1;
for (i = 2; i <= 10; i++) {
  fib[i] = fib[i - 2] + fib[i - 1];
  console.log(fib[i]);
}


let valor = parseInt(gets());

let arr = [];

const fibonacci = (n) => 
{
  if (n < 2) 
  {
    return n;
  } 
        
  else 
  {
    return fibonacci(n - 1) + fibonacci(n - 2);
  }
}

  for (let i = 0; i < valor; i++) 
  {
    arr.push(fibonacci(i));
  }

console.log(arr.join(' '));