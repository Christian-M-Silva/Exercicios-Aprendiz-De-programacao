Algoritmo "semnome"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/09/2021
Var
// Se��o de Declara��es das vari�veis 
custo_fabrica, porcentagem_distribuidor, porcentagem_imposto, custo_final: real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
Escreval("Digite um custo de fabrica")
Leia(custo_fabrica)

porcentagem_distribuidor:= custo_fabrica + (custo_fabrica * 28/100)
porcentagem_imposto:= custo_fabrica + (custo_fabrica * 45/100)
custo_final := porcentagem_distribuidor + porcentagem_imposto + custo_fabrica

Escreval("O custo final para o consumidor �", custo_final)

Fimalgoritmo