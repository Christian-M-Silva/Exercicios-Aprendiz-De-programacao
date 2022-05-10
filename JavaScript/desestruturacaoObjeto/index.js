const pessoa = {
    name: "Christian",
    age: 20,
    sexo: "masculino"
}

const {name :nome, ...itemQueNaoPeguei} = pessoa

console.log(`Meu nome é ${nome}, tenho ${itemQueNaoPeguei.age} anos e sou do sexo ${itemQueNaoPeguei.sexo}`)