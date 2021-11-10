Algoritmo "nota_aluno_procedimetos"

Var
nota1, nota2, nota3, nota4: real

procedimento media(m1, m2, m3, m4: real)
var
media_final: real

inicio

media_final:= (m1+m2+m3+m4)/4

se (media_final < 5) entao
   escreval("Você ta ferrado meu parcero")
senao
     se (media_final = 5) entao
        escreval("A uma luz no fim do tunel")
     senao
        escreval("O pai ta chato")
     fimse
fimse

escreval()
escreval("A sua nota no final do bimestre foi", media_final)
fimprocedimento

Inicio
escreval("Digite a nota do primeiro bimestre")
leia(nota1)
escreval()

escreval("Digite a nota do segundo bimestre")
leia(nota2)
escreval()

escreval("Digite a nota do terceiro bimestre")
leia(nota3)
escreval()

escreval("Digite a nota do quarto bimestre")
leia(nota4)
escreval()

media(nota1, nota2, nota3, nota4)

Fimalgoritmo