Algoritmo " multiplicação_5"

Var
n: vetor[1..10] de real
multiplicacao : vetor[1..10] de real
c: inteiro

Inicio
para c de 1 ate 10 faca
     escreval("Digite um número")
     leia(n[c])
     escreval("")
fimpara

para c de 1 ate 10 faca
     multiplicacao[c] := n[c] * 5
fimpara

para c de 1 ate 10 faca
     escreval(n[c] ," x 5 = ", multiplicacao[c])
     escreval("")
     c := c + 1
fimpara

Fimalgoritmo