Algoritmo "reajuste"

Var
salario: real
salario_antigo: real

procedimento reajuste(var nv: real)
inicio
nv:= nv *1.20

fimprocedimento

Inicio
escreval("Escreva seu salario")
leia(salario)

salario_antigo:= salario

reajuste(salario)

escreval("Seu sálario foi reajustado para", salario)



Fimalgoritmo