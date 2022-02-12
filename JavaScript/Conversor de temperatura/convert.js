let unity = ""
let result = 0
function convert(){
    unity = prompt("Digite a letra que corresponde a temperatura que você quer converetre").toUpperCase();
    temperature = Number(prompt("Digite a temperatura"))
    
    switch (unity) {
        case "F":
            result = temperature * 9/5 + 32;
            alert(`${result.toFixed(2)}°C`) 
            break;
        
        case "C":
            result = (temperature - 32) * 5/9
            alert(`${result.toFixed(2)}°F`) 
            break;
    
        default:
            alert("O valor que você digitou é invalido, tente novamente.")
            break;
    }
}