Algoritmo "Par_ou_impar"

Var
n, resto: inteiro


Inicio
escreval("Digite o n�mero")
leia(n)

resto := n%2

se (resto = 0) entao
   escreval("O n�mero que vem antes de", n ," �", n-1)
senao
   escreval("O n�mero que vem depois de", n ," �", n+1)
fimse


Fimalgoritmo