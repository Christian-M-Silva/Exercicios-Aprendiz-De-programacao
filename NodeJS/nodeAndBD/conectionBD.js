const Sequelize = require('sequelize')
const sequelize = new Sequelize('users', 'root', '13072001', {
    host: "localhost",
    dialect: "mysql"
})

sequelize.authenticate().then(() => console.log("Conectado com sucesso!!!")).catch((erro) => console.log(`Falha ao se conectar: ${erro}`))