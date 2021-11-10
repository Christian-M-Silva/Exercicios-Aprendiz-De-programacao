Algoritmo "Agencia"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Carlos Fico
// Descrição   : Faz o cadastro e consulta de um cliente para uma agencia de viagens
// Autor(a)    : Christian Morais Silva
// Data atual  : 23/10/2021
Var
   quero, i, vezes: inteiro
   tabela: vetor[1..50,1..4] de caracter
   cpf: caracter

Inicio
   escreval("Olá seja bem-vindo(a) me chamo Alex e serei seu guia nessa viagem")
   escreval()
   escreval("Para comerçarmos digite o número que corresponde a opção desejada:")
   escreval()
   escreval("1- Fazer cadastro do(a) cliente")
   escreval("2- Fazer consulta do cadastro do(a) cliente")
   escreval("3- Finalizar programa")
   escreval()
   leia(quero)
   limpatela

   enquanto (quero = 1) ou (quero = 2) faca
      se (quero = 1) entao
         escreval("-----------------Bem-vindo(a) a tela de cadastro-----------------")
         escreval()
         escreval("Para comerçarmos digite quantas pessoa você quer cadastrar em forma númerica(Max.50 pessoas)")
         escreval()
         leia(i)
         limpatela

         para i de 1 ate i faca
            escreval("Digite o nome completo do(a) cliente")
            leia(tabela[i, 1])
            escreval()

            escreval("Digite a idade do(a) cliente")
            leia(tabela[i,2])
            escreval()

            escreval("Digite o cpf do(a) cliente (somente números)")
            leia(tabela[i,3])
            escreval()

            escreval("Digite o local de destino do(a) cliente")
            leia(tabela[i,4])
            escreval()

            escreval("Cliente ", tabela[i, 1] ," cadastrado")
            limpatela
         fimpara


         escreval("Cadastro concluido")
         limpatela

         escreval("O que deseja fazer agora?")
         escreval
         escreval("Digite o número que corresponde a opção desejada:")
         escreval()
         escreval("1- Refazer cadastro do(a) cliente")
         escreval("2- Fazer consulta do cadastro do(a) cliente")
         escreval("3- Finalizar programa")
         escreval()
         leia(quero)
         limpatela

      senao se (quero =2)faca
         escreval("Digite o cpf do(a) cliente que deja consultar")
         leia(cpf)
         escreval()
         vezes := 0
         para i de 1 ate 50 faca
            se (cpf = tabela[i, 3]) entao
               escreval("Nome| Idade | Cpf | Local de destino")
               escreval()
               escreval(tabela[i, 1], " | " ,tabela[i, 2], " | " ,tabela[i, 3], " | " ,tabela[i, 4])
               vezes:= vezes + 1
               escreval()
            fimse
         fimpara
         se (vezes = 0) entao
            escreval("Cliente não cadastrado, cadastre um cliente")
            escreval()
         fimse
         escreval("Digite o número que corresponde a opção desejada:")
         escreval()
         escreval("1- Refazer cadastro do(a) cliente")
         escreval("2- Fazer consulta do cadastro do(a) cliente")
         escreval("3- Finalizar programa")
         escreval()
         leia(quero)
         limpatela
      fimse
   fimenquanto

   se(quero = 3) entao
      escreval("O programa irá se encerrar até uma proxima oportunidade")
      escreval()
      escreval("-----------------Fim do programa-----------------")
   senao se(quero !=1) e (quero !=2) e (quero !=3) entao
      escreval("A opção que você selecionou não corresponde com nenhuma do menu, o programa irá se encerrar.")
   fimse


Fimalgoritmo