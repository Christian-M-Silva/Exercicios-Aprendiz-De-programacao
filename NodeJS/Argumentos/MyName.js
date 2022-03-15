function myName(firstName, lastName) {
    firstName = process.argv[2]
    lastName= process.argv[3]
    return `Seu nome é ${firstName} ${lastName}`
}

console.log(myName())