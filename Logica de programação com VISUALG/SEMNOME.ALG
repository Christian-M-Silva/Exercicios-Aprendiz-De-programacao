Algoritmo "Par_Impar"

Var
par: vetor[1..10] de inteiro
impar: vetor[1..10] de inteiro
cp: inteiro
ci: inteiro
c: inteiro
n: inteiro

Inicio

para c de 1 ate 10 faca
     escreval("Digite um n�mero que n�o seja 0")
     leia(n)
     
     enquanto (n = 0) faca
              escreval("Zero � n�mero inv�lido. Digite outro n�mero:")
              leia(n)
     fimenquanto
     
     se(n % 2 = 0) entao
               par[c]:= n
     senao
          impar[c]:= n
     fimse
     
     c := c + 1
     escreval("")
fimpara


escreval("Os n�meros pares s�o")
escreval("")

para cp de 1 ate 10 faca
     escreval(par[cp])
     cp:= cp + 1
fimpara

escreval("Os n�meros impares s�o")

para ci de 1 ate 10 faca
     escreval(impar[ci])
     ci:= ci + 1
fimpara

Fimalgoritmo