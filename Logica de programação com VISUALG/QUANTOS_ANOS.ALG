Algoritmo "quantos_anos"

Var
dia, mes, ano, ano_atual : inteiro
tempo_dia, tempo_mes, tempo_ano : real

Inicio
escreval("Digite o dia em que voc� nasceu")
leia(dia)

escreval("Digite o m�s em que voc� nasceu")
leia(mes)

escreval("Digite o ano em que voc� nasceu")
leia(ano)

escreval("Digite o ano em que voc� est� no momento")
leia(ano_atual)

tempo_mes := (mes * 30) - (30 - dia)

tempo_ano :=  (ano_atual - ano) * 365

tempo_dia :=  tempo_ano + tempo_mes

escreval("Voc� tem", tempo_dia)


Fimalgoritmo