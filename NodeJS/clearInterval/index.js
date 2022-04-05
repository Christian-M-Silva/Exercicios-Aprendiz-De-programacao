const time = 3000;
const back = () => {
    console.log("Tinha o pete e o repete, o pete morreu, quem ficou?")
    console.log("Repete")}
const interval = setInterval(back, time);

setTimeout(() => {
    clearInterval(interval)
    console.log("Chega!!!")
}, 10000);

