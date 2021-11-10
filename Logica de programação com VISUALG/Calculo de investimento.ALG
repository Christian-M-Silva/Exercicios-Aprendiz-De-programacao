Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/09/2021
Var
// Seção de Declarações das variáveis
valor_inicial, valor_final: real
tipo_investimento: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("Qual valor você quer investir")
leia(valor_inicial)

escreval("Escolha o tipo de investimento")
escreval("Digite '1' para POUPANÇA")
escreval("Digite '2' para RENDA FIXA")
leia(tipo_investimento)

se tipo_investimento = 1 entao
valor_final:= valor_inicial + (valor_inicial * (5/100))
senao
valor_final:= valor_inicial + (valor_inicial * (10/100))

fimse

escreval("O valor final com o investimento é", valor_final)

Fimalgoritmo