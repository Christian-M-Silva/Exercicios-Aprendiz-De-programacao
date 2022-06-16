let firstNumber = [1, 2, 3, 4, 5]
let secondNumber = [...firstNumber, 6, 7, 8, 9, 10]


let dadosPessoais = {
    name: "Christian",
    age: 20,
    sex: "Man"
}

let dadosProfissionais = {
    ...dadosPessoais,
    area: "TI",
    cargo: "Desenvolvedor Aprendiz"
}
console.log(secondNumber[0])

