Algoritmo "semnome"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/09/2021
Var
// Se��o de Declara��es das vari�veis
valor_inicial, valor_final: real
tipo_investimento: inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreval("Qual valor voc� quer investir")
leia(valor_inicial)

escreval("Escolha o tipo de investimento")
escreval("Digite '1' para POUPAN�A")
escreval("Digite '2' para RENDA FIXA")
leia(tipo_investimento)

se tipo_investimento = 1 entao
valor_final:= valor_inicial + (valor_inicial * (5/100))
senao
valor_final:= valor_inicial + (valor_inicial * (10/100))

fimse

escreval("O valor final com o investimento �", valor_final)

Fimalgoritmo