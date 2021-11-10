function peso(){
    let peso = prompt("Digite o seu peso em número");

    if(peso >= 80){
        alert("Você tem que tomar cuidado");
    }
    else if(peso < 80){
        alert("Você está em forma")
    }
    else{
        alert("O valor digitado não é um número")
    }
}