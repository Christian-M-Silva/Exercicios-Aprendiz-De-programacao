Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 26/09/2021
Var
// Seção de Declarações das variáveis 
produto_inicial, desconto, produto_desconto, resutado_divisao: real


Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
Escreval("Digite o valor sem o desconto")
leia(produto_inicial)

Escreval("Digite o desconto sem a porcentagem")
leia(desconto)

resutado_divisao := produto_inicial * desconto /100
produto_desconto := produto_inicial - resutado_divisao

Escreval("O novo valor é", produto_desconto)




Fimalgoritmo