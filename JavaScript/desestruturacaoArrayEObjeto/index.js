/*
function desestruturar({christian}) {
    console.log(christian.name.firstName)
};

const pessoas = {
    christian:{
        name:{
            firstName: "Christian",
            lastName: "Silva"
        },
        age: 21
    },

    thayna:{
        name:{
            firstName: "Thayná",
            lastName: "Cordeiro"
        },
        age: 23
    }
};

desestruturar(pessoas)*/

const colorFruits = [
    ["maça", "morango"],
    ["pera", "kiwi"]
]

colorFruits.map(([key, value])=>{
    console.log(key, value)
})