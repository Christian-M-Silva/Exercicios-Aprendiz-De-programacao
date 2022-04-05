const { inherits } = require('util')
const { EventEmitter } = require('events')

function Who(name) {
    this.name = name
}

inherits(Who, EventEmitter)

const who = new Who('Batman')

who.on('question', (name) => console.log(`Eu sou o ${name} !!!`))

console.log("Você está pensando que é quem?")

who.emit('question', who.name)

