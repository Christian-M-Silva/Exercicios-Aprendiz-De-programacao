Algoritmo "Calculadora"

Var
n1, n2, operacao:real


Inicio
escreval("Digite o primeiro número")
leia(n1)

escreval("Digite o segundo número")
leia(n2)

escreval("Digite o NÚMERO correspondente a sua operação mátematica")
escreval("(1) SOMA")
escreval("(2) SUBTRAÇÃO")
escreval("(3) MULTIPLICAÇÃO")
escreval("(4) DIVISÃO")
leia(operacao)

escolha (operacao)
caso = 1
     escreval("O valor da sua soma é", n1+n2)
caso = 2
     escreval("O valor da sua subtração é", n1-n2)
caso = 3
     escreval("O valor da sua multiplicação é", n1*n2)
caso = 4
     escreval("O valor da sua divisão é", n1/n2)
outrocaso
     escreval("OPS! pelo visto digitou algo errado, forneça novamente as informações de atentando para o que se pede")

fimescolha


Fimalgoritmo