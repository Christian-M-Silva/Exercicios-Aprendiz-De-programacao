const {EventEmitter} = require('events')
const event = new EventEmitter()

event.on('saySomething', (name) => {
    console.log(`Eu ouvi você ${name}`)
})

event.emit('saySomething', "Christian")
event.emit('saySomething', "Thayná")