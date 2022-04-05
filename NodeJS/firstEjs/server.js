const express = require('express')
const project = express();

project.set("view engine", "ejs");

project.get("/", function (req, res) {
    res.render("pages/index");
})

project.get("/about", function (req, res) {
    res.render("pages/about");
})

project.get("/contact", function (req, res) {
    res.render("pages/contact");
})

project.listen(8080)
console.log("Abra o navegador e digite isso: localhost:8080")