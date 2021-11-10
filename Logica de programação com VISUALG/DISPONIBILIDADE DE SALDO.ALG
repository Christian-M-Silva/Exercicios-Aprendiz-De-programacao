Algoritmo "Disponibilidade de saldo"

Var
saque : real


Inicio
escreval("Escreva o valor que deseja sacar:")
leia(saque)

se (saque <= 1000) entao
   escreval("O saldo é maior que o valor do saque, poderá concluir o saque")
senao
   escreval("O saldo é menor que o valor do saque, não poderá concluir o saque")
fimse

Fimalgoritmo