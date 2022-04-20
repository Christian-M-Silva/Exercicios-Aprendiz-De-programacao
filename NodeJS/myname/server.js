const express = require('express')
const app = express();

app.get("/", function(req, res) {
    res.sendFile(__dirname + "/pages/index.html")
})

app.listen(8080, function(){
    console.log("Abra seu navegador na url: localhost:8080")
})