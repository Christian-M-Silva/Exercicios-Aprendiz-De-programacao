const http = require('http')
const name = "Christian"

http.createServer(function(req, res) {
    res.end(`Hello ${name}, this is my website!!!`)
}).listen(8080)

console.log("Abra o navegador e digite: localhost:8080 ")