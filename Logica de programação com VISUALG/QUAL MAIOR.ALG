Algoritmo "Qual maior"

Var
n1, n2, n3 :inteiro


Inicio
escreval("Escreva o primeiro n�mero")
leia(n1)

escreval("Escreva o segundo n�mero")
leia(n2)

escreval("Escreva o terceiro n�mero")
leia(n3)

se (n1>n2) e (n1>n3) entao
   escreval("O primeiro n�mero � maior")
senao
   se (n2> n1) e (n2> n3) entao
      escreval("O segundo n�mero � maior")
   senao
      escreval("O terceiro n�mero � o maior")
   fimse
fimse


Fimalgoritmo