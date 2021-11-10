Algoritmo "Verificar negativo, positivo, 0"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi

Var
   n: real

Inicio
   escreval("Escreva um número")
   leia(n)

   se n < 0 entao
      escreval("O número é negativo")
   senao
        se n = 0 entao
           escreval("Número digitado é 0")
        senao
           escreval("O número é positivo")
        fimse
   fimse


Fimalgoritmo