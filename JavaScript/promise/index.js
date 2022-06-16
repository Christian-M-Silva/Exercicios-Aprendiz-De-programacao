const imAm = false
const promise = new Promise((resolve, reject) => {
    if (imAm) {
        return resolve("I'm Batman")
    } else {
        return reject("I'm not Batman")
    }
})

promise
    .then(result => console.log(result))
    .catch(err => console.log(err))
    .finally(end => console.log("Pow!"))
    
console.log("Who are you?")