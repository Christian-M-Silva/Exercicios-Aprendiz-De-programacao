Algoritmo "Soma_tudo"

Var
n: vetor[1..5] de real
soma_total: real
c: inteiro

Inicio
para c de 1 ate 5 faca
     escreval("Digite um n�mero")
     leia (n[c])
     soma_total := n[c] + soma_total
     c := c + 1
fimpara

escreval("")
escreval("A soma de todos os dados digitados �", soma_total)

para c de 1 ate 5 faca
     escreval("")
     escreval("O n�mero digitado no �ndice", c ," �", n[c])
     c := c + 1
fimpara

Fimalgoritmo