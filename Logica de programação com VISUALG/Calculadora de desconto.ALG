Algoritmo "semnome"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 26/09/2021
Var
// Se��o de Declara��es das vari�veis 
produto_inicial, desconto, produto_desconto, resutado_divisao: real


Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
Escreval("Digite o valor sem o desconto")
leia(produto_inicial)

Escreval("Digite o desconto sem a porcentagem")
leia(desconto)

resutado_divisao := produto_inicial * desconto /100
produto_desconto := produto_inicial - resutado_divisao

Escreval("O novo valor �", produto_desconto)




Fimalgoritmo