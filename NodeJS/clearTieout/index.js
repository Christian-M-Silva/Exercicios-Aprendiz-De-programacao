const time = 6000;
const back = () => console.log("I´m back")
const timeout = setTimeout(back, time)

console.log("I'll be back")

if (time > 3000) {
    clearTimeout(timeout)
    console.log("Demorou demais para voltar")
}