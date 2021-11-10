Algoritmo "Soma_tudo_exibição_inversa"

Var
n: vetor[1..5] de real
soma_total: real
c: inteiro

Inicio
para c de 1 ate 5 faca
     escreval("Digite um número")
     leia (n[c])
     soma_total := n[c] + soma_total
fimpara

escreval("")
escreval("A soma de todos os dados digitados é", soma_total)

para c de 5 ate 1 passo -1 faca
     escreval("")
     escreval("O número digitado no índice", c ," é", n[c])
fimpara

Fimalgoritmo