const express = require('express')
const app = express();

/* GET
app.route("/").get((req, res) => res.send("Hello World"))
app.route("/sobre").get((req, res) => res.send("Seja Bem-vindo a pág sobre"))*/

/* POST
app.use(express.json())
app.route("/").post((req,res) => res.send(req.body))*/

/* PUT
app.use(express.json())

let author = "Deivid"

app.route("/").get((req, res) => res.send(author))

app.route("/").put((req,res) => {
	author = req.body.author
	res.send(author)
})*/

/* DELETE
app.route("/:id").delete((req, res) => res.send(req.params.id))*/



app.listen(8080, function(){
	console.log("Servidor Rodando na porta 8080")
})
