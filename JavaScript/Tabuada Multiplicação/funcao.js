function pedirNumero(){
    let n= prompt("Digite um número");
    let c= 1;

    while(n<10){
        document.write(n + " x " + c + " = " + n*c + "<br>");
        n++;
    }
}