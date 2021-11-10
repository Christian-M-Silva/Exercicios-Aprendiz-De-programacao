Algoritmo "semnome"

Var
contador: inteiro
n, operacao: real

Inicio
escreval ("Digite o número")
leia(n)

escreval("")

escreval("Digite o NÚMERO correspondente a operação desejada")
escreval("(1) Soma")
escreval("(2) Subtração")
escreval("(3) Multiplicação")
escreval("(4) Divisão")
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
             escreval("O número digitado não corresponde a nenhuma operação")
         fimescolha

         contador:= contador+1
fimenquanto


Fimalgoritmo