Algoritmo "Disponibilidade de saldo"

Var
saque : real


Inicio
escreval("Escreva o valor que deseja sacar:")
leia(saque)

se (saque <= 1000) entao
   escreval("O saldo � maior que o valor do saque, poder� concluir o saque")
senao
   escreval("O saldo � menor que o valor do saque, n�o poder� concluir o saque")
fimse

Fimalgoritmo