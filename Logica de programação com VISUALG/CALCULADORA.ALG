Algoritmo "Calculadora"

Var
n1, n2, operacao:real


Inicio
escreval("Digite o primeiro n�mero")
leia(n1)

escreval("Digite o segundo n�mero")
leia(n2)

escreval("Digite o N�MERO correspondente a sua opera��o m�tematica")
escreval("(1) SOMA")
escreval("(2) SUBTRA��O")
escreval("(3) MULTIPLICA��O")
escreval("(4) DIVIS�O")
leia(operacao)

escolha (operacao)
caso = 1
     escreval("O valor da sua soma �", n1+n2)
caso = 2
     escreval("O valor da sua subtra��o �", n1-n2)
caso = 3
     escreval("O valor da sua multiplica��o �", n1*n2)
caso = 4
     escreval("O valor da sua divis�o �", n1/n2)
outrocaso
     escreval("OPS! pelo visto digitou algo errado, forne�a novamente as informa��es de atentando para o que se pede")

fimescolha


Fimalgoritmo