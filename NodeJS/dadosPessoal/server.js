const express = require('express')
const app = express()

app.get('/', function(req, res) {
   res.send("<h1>Olá pessoal, seja bem vindo a minha Home pág</h1>") 
})

app.get('/sobre/:nome/:idade', function(req, res) {
    res.send(`<h1>Olá <strong>${req.params.nome}</strong>, você tem <strong>${req.params.idade}</strong> anos.</h1>`)
})

app.listen(8080, () => {
    console.log("Abra seu navegador em localhost:8080")
})