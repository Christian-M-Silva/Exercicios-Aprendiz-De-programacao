const express = require("express")
const app = express()
const axios = require("axios")

app.route("/").get( (req,res)=> {
    axios.get("https://api.github.com/users/Christian-M-Silva")
        .then(result => res.send(`<img src="${result.data.avatar_url}" alt="Foto perfil"></img>`))
        .catch(err => console.log(err))
} )

app.listen("8080", () => console.log(`Rodando na porta 8080`))