Algoritmo "Par_ou_impar"

Var
n, resto: inteiro


Inicio
escreval("Digite o número")
leia(n)

resto := n%2

se (resto = 0) entao
   escreval("O número que vem antes de", n ," é", n-1)
senao
   escreval("O número que vem depois de", n ," é", n+1)
fimse


Fimalgoritmo