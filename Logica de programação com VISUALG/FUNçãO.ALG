Algoritmo "fun��o"

Var
n1, n2, soma: real

funcao somar(a,b:real):real
var
soma: real
inicio
soma := a + b
retorne soma
fimfuncao

Inicio
escreval("Digite um n�mero")
leia(n1)

escreval()

escreval("Digite outro n�mero")
leia(n2)

soma := somar(n1,n2)

escreval("O valor da soma de", n1 ," +", n2 ," �", soma)

Fimalgoritmo