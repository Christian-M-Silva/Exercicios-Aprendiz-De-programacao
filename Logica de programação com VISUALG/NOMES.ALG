Algoritmo "Nomes"

Var
n: vetor [1..5] de caracter
c: inteiro

Inicio
c := 1

enquanto (c <=5) faca
         escreval("Digite um n�mero")
         leia(n[c])
         escreval("")
         c := c + 1
fimenquanto

escreval("A lista na ordem digitada �:")

para c de 1 ate 5 faca
     escreval("")
     escreval("O nome no �ndice", c ," � ", n[c])
     c := c + 1
fimpara

escreval("")
escreval("A lista na ordem inversa �:")

repita
      escreval("")
      escreval("O nome no �ndice", c ," � ", n[c])
      c := c - 1
ate c < 1

Fimalgoritmo