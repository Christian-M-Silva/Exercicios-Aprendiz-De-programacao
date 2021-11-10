Algoritmo "peso_no_planeta"

Var
peso_t: real
peso_outro_planeta: inteiro
Inicio
escreval("Digite o seu peso na terra")
leia(peso_t)

escreval("")

escreval("Digite o NÚMERO CORRRESPONDENTE ao planeta dessejado")
escreval("1 - Mercúrio")
escreval("2 - Vênus")
escreval("3 - Marte")
escreval("Qualquer outro número - Júpter")
leia(peso_outro_planeta)

escolha (peso_outro_planeta)
        caso =1
             escreval("O seu peso é", (peso_t/10) * 0.37)
        caso =2
             escreval("O seu peso é", (peso_t/10) * 0.88)
        caso =3
             escreval("O seu peso é", (peso_t/10) * 0.38)
        outrocaso
             escreval("O seu peso é", (peso_t/10) * 2.64)
fimescolha


Fimalgoritmo