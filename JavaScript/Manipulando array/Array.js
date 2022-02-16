/*/* 
    ∞ Buscando e contando dados em Arrays ∞
    Baseado no Array de Livros por Categoria abaixo, faça os seguintes desafios
        • Contar o número de categorias e o número de livros em cada categoria
        • Contar o número de autores
        • Mostrar livros do autor Auguto Cury
        • Transformar o código acima em uma função que irá receber o nome do autor e devolver os livros desse autor.
*/
let quantitiesBooks = 0;
let quantitiesCategories = 0;
let quantitiesAuthor = 0;

const booksByCategory = [
    {
        category: "Riqueza",
        books: [
            {
                title: "Os segredos da mente milionária",
                author: "T. Harv Eker",
            },
            {
                title: "O homem mais rico da Babilônia",
                author: "George S. Clason",
            },
            {
                title: "Pai rico, pai pobre",
                author: "Robert T. Kiyosaki e Sharon L. Lechter",
            },
        ],
    },
    {
        category: "Inteligência Emocional",
        books: [
            {
                title: "Você é Insubstituível",
                author: "Augusto Cury",
            },
            {
                title: "Ansiedade – Como enfrentar o mal do século",
                author: "Augusto Cury",
            },
            {
                title: "Os 7 hábitos das pessoas altamente eficazes",
                author: "Stephen R. Covey",
            },
        ],
    }
]; 

/*Contar a quantidade de categorias do livro*/
quantitiesCategories = booksByCategory.length;
console.log("Existe " + quantitiesCategories + " categorias de livros");

/*Contar a quantidade de categorias do livros*/
for (let i = 0; i < booksByCategory.length; i++) {
    quantitiesBooks += booksByCategory[i].books.length;   
}
console.log("Existe " + quantitiesBooks + " livros")

/*Contar o número de autores*/
for (let i = 0; i < booksByCategory.length; i++) {
    for (let c = 0; c < booksByCategory[i].books.length; c++) {
        for (let author in booksByCategory[i].books[c]) {
            if (author == "author") {
                quantitiesAuthor++;   
            }
        }  
    }
}
console.log("Existe " + quantitiesAuthor + " autores")

 /*Mostrar livros do autor Auguto Cury */   
 for (let i = 0; i < booksByCategory.length; i++) {
    for (let c = 0; c < booksByCategory[i].books.length; c++){
        for (let category in booksByCategory[i].books[c]) {
            if(category == "author"){
                if(booksByCategory[i].books[c][category] == "Augusto Cury"){
                   console.log(booksByCategory[i].books[c].title + " é um livro de Augusto Cury") 
                    
                }
            }
        }
    }
 }

 /*Uma função que irá receber o nome do autor e devolver os livros desse autor */
 function consultAuthor(name) {
    for (let i = 0; i < booksByCategory.length; i++) {
        for (let c = 0; c < booksByCategory[i].books.length; c++){
            for (let category in booksByCategory[i].books[c]) {
                if(category == "author"){
                    if(booksByCategory[i].books[c][category] == name){
                       console.log(booksByCategory[i].books[c].title + " é um livro de " + name) 
                        
                    }
                }
            }
        }
     }
 }
 consultAuthor("Auguto Cury")