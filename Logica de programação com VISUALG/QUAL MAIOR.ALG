Algoritmo "Qual maior"

Var
n1, n2, n3 :inteiro


Inicio
escreval("Escreva o primeiro número")
leia(n1)

escreval("Escreva o segundo número")
leia(n2)

escreval("Escreva o terceiro número")
leia(n3)

se (n1>n2) e (n1>n3) entao
   escreval("O primeiro número é maior")
senao
   se (n2> n1) e (n2> n3) entao
      escreval("O segundo número é maior")
   senao
      escreval("O terceiro número é o maior")
   fimse
fimse


Fimalgoritmo