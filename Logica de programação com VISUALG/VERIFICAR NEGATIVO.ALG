Algoritmo "Verificar negativo, positivo, 0"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi

Var
   n: real

Inicio
   escreval("Escreva um n�mero")
   leia(n)

   se n < 0 entao
      escreval("O n�mero � negativo")
   senao
        se n = 0 entao
           escreval("N�mero digitado � 0")
        senao
           escreval("O n�mero � positivo")
        fimse
   fimse


Fimalgoritmo