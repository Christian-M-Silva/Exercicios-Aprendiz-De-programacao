Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/09/2021
Var
// Seção de Declarações das variáveis 
custo_fabrica, porcentagem_distribuidor, porcentagem_imposto, custo_final: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
Escreval("Digite um custo de fabrica")
Leia(custo_fabrica)

porcentagem_distribuidor:= custo_fabrica + (custo_fabrica * 28/100)
porcentagem_imposto:= custo_fabrica + (custo_fabrica * 45/100)
custo_final := porcentagem_distribuidor + porcentagem_imposto + custo_fabrica

Escreval("O custo final para o consumidor é", custo_final)

Fimalgoritmo