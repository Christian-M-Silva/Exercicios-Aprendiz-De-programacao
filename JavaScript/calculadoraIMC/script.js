
function IMC(event) {
    event.preventDefault()
    const peso = document.getElementById("peso").value
    const altura = document.getElementById("altura").value
    const imcCalc = peso / (altura * altura)
    const imc = imcCalc.toFixed(2)
    const response = document.getElementById("response")

    if (imc < 17) {
        response.innerHTML = `<h1>Você está muito abaixo do peso!!! <br> Seu IMC é ${imc}</h1>`
    } else if (imc >= 17 && imc <= 18.49 ) {
        response.innerHTML = `<h1>Você está abaixo do peso <br> Seu IMC é ${imc}</h1>`
    } else if (imc >= 18.5 && imc<=24.99) {
        response.innerHTML = `<h1>Seu peso está normal <br> Seu IMC é ${imc}</h1>`
    } else{
        response.innerHTML = `<h1>Você está muito acima do peso!!! <br> Seu IMC é ${imc}</h1>`
    }

    document.getElementById("peso").value=""
    document.getElementById("altura").value=""
}
