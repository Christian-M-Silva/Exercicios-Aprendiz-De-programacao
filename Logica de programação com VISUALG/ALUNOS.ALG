Algoritmo "alunos"

Var
alunos: vetor[1..5, 1..3] de caracter
c: inteiro

Inicio
para c de 1 ate 5 faca
     escreval("Digite o nome do aluno")
     leia(alunos[c,1])
     escreval("")
     escreval("Digite a nota do aluno")
     leia(alunos[c,2])
     escreval("")
     escreval("Digite a turma do aluno")
     leia(alunos[c,3])
     escreval("")
fimpara

para c de 1 ate 5 faca
     escreval("Nome do aluno(a) é:", alunos[c,1])
     escreval("Nota do aluno(a) é:", alunos[c,2])
     escreval("Turma do aluno(a) é:", alunos[c,3])
     escreval("")
fimpara

fimalgoritmo