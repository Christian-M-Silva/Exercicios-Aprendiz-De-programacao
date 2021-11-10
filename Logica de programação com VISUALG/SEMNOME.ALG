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
     escreval("Digite um número que não seja 0")
     leia(n)
     
     enquanto (n = 0) faca
              escreval("Zero é número inválido. Digite outro número:")
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


escreval("Os números pares são")
escreval("")

para cp de 1 ate 10 faca
     escreval(par[cp])
     cp:= cp + 1
fimpara

escreval("Os números impares são")

para ci de 1 ate 10 faca
     escreval(impar[ci])
     ci:= ci + 1
fimpara

Fimalgoritmo