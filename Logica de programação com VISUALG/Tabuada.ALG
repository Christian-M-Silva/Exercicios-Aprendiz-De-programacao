Algoritmo "semnome"

Var
contador: inteiro
n, operacao: real

Inicio
escreval ("Digite o n�mero")
leia(n)

escreval("")

escreval("Digite o N�MERO correspondente a opera��o desejada")
escreval("(1) Soma")
escreval("(2) Subtra��o")
escreval("(3) Multiplica��o")
escreval("(4) Divis�o")
leia(operacao)

contador := 1

escreval("")

enquanto contador <= 10 faca
         escolha(operacao)
           caso = 1
             escreval(n ," +", contador ," =", n + contador)
           caso = 2
             escreval(n ," -", contador ," =", n - contador)
           caso = 3
             escreval(n ," x", contador ," =", n * contador)
           caso = 4
             escreval(n ," /", contador ," =", n / contador)
           outrocaso
             escreval("O n�mero digitado n�o corresponde a nenhuma opera��o")
         fimescolha

         contador:= contador+1
fimenquanto


Fimalgoritmo