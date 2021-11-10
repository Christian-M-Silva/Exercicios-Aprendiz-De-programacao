/* Fazer um programa para digitar dois números no prompt e fazer a multiplicação destes dois valores. Pode ser usado o parseFloat ou o parseInt.
Exibir o resultado através do método alert.

*/

function multiplicar(){
    let n1= prompt("Digite o primeiro número");
    n1 = parseFloat(n1);

    let n2= prompt("Digite o segundo número");
    n2 = parseFloat(n2);

    alert("O resultado é " +  n1*n2);
}