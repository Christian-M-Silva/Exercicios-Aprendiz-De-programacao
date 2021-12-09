package calculadora;
import java.util.Scanner;

public class Calculadora {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
		int num1 = 0;
		int num2 = 0;
		int resultado = 0;
		String operacao = "";
		
		
		System.out.println("-------------Olá seja bem vindo a sua calculadora----------- ");
		System.out.println();
		
		System.out.println("Digite o primeiro número a ser calculado");
		num1 = teclado.nextInt();
		System.out.println();
		
		System.out.println("Digite o segundo número a ser calculado");
		num2 = teclado.nextInt();
		System.out.println();
		
		System.out.println("Digite o símbolo da operação a ser feita");
		System.out.println("Digite + para somar");
		System.out.println("Digite - para subtrair");
		System.out.println("Digite * para multiplicar");
		System.out.println("Digite / para dividir");
		operacao = teclado.next();
		System.out.println();
		
		switch(operacao) {
			case "+":
				resultado = num1 + num2;
				System.out.println(num1 + "" + operacao + "" + num2 + "=" + resultado);
				break;
				
			case "-":
				resultado = num1 - num2;
				System.out.println(num1 + "" + operacao + "" + num2 + "=" + resultado);
				break;
				
			case "*":
				resultado = num1 * num2;
				System.out.println(num1 + "" + operacao + "" + num2 + "=" + resultado);
				break;
				
			case "/":
				resultado = num1 / num2;
				System.out.println(num1 + "" + operacao + "" + num2 + "=" + resultado);
				break;
				
			default:
				System.out.println("O simbolo da operação que você digitou foi errado, por favor tente novamente");
		}
	
		teclado.close();
		

	}

}
