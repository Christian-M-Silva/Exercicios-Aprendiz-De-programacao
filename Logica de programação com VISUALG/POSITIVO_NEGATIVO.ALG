Algoritmo "Positivo_Negativo"

Var
valor, positivo, negativo, contador : inteiro


Inicio
para contador de 1 ate 5 faca
     escreval("Digite um valor")
     leia(valor)
     escreval("")
     se (valor > 0) entao
        positivo := valor + positivo
     senao
        negativo := negativo + 1
     fimse
fimpara

escreval("A soma do(s) n�mero(s) positivo(s) totaliza", positivo)

escreval("")

escreval("Teve", negativo ," n�mero(s) negativo(s)")


Fimalgoritmo