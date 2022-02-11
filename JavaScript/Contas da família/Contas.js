/*Crie um objeto que possuirá 2 propriedades, ambas do tipo array:
    * receitas: [] 
    * despesas: []
Agora, crie uma função que irá calcular o total de receitas e 
despesas e irá mostrar uma mensagem se a família está com 
saldo positivo ou negativo, seguido do valor do saldo. */

let i = 0;
let amountIncome = 0;
let amountExpenditure = 0;
let addIncome = 0;
let addExpenditure = 0;

let familyAccounts = {
    income: [],
    expenditure: []
}

function balanceCalculation(){
    amountIncome = Number(prompt("Quantas receitas você têm?"))
    amountExpenditure = Number(prompt("Quantas despesas você têm?"))

    for (i = 0; i < amountIncome; i++) {
        familyAccounts.income[i] = Number(prompt("Digite aqui quanto é sua receita: (Obs.: Digite 0 a qualquer momento para cancelar e números decimais com pontos (Ex.: 2.50))")) 

        if(familyAccounts.income[i] == 0){
            break;
        }
    }

    for (i = 0; i < amountExpenditure; i++) {
        familyAccounts.expenditure[i] =  Number(prompt("Digite aqui quanto é sua depesa: (Obs.: Digite 0 a qualquer momento para cancelar e números decimais com pontos (Ex.: 2.50))"))  

        if(familyAccounts.expenditure[i] == 0){
            break;
        }
    }

    for (i = 0; i < familyAccounts.income.length; i++) {
        addIncome = addIncome + familyAccounts.income[i]
    }

    for (i = 0; i < familyAccounts.expenditure.length; i++) {
        addExpenditure = addExpenditure + familyAccounts.expenditure[i]
    }

    document.getElementsByTagName('h1')[0].innerHTML= addIncome >= addExpenditure ? `Seu saldo está positivo pois você tem ${addIncome - addExpenditure}$ de saldo`: `Seu saldo está negativo pois você tem ${addIncome - addExpenditure}$ de saldo`
}
