Algoritmo "Soma_tudo_exibi��o_inversa"

Var
n: vetor[1..5] de real
soma_total: real
c: inteiro

Inicio
para c de 1 ate 5 faca
     escreval("Digite um n�mero")
     leia (n[c])
     soma_total := n[c] + soma_total
fimpara

escreval("")
escreval("A soma de todos os dados digitados �", soma_total)

para c de 5 ate 1 passo -1 faca
     escreval("")
     escreval("O n�mero digitado no �ndice", c ," �", n[c])
fimpara

Fimalgoritmo