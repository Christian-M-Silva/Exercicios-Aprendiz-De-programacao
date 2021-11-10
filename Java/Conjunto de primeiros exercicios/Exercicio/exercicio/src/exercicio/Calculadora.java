package exercicio;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Calculadora {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
			int num = 0, ndois = 0, resultado = 0;
			String operacao = null;
			
			try {
				System.out.println("Digite um número");
				num= teclado.nextInt();
				System.out.println();
				
				System.out.println("Digite outro número");
				ndois= teclado.nextInt();
				System.out.println();
				
				System.out.println("Escolha o sinal de operação só pode ser: \n+ (para soma) \n- (para subtração) \n* (para multiplicação) \n/ (para divisão)");
				operacao = teclado.next();
				System.out.println();
				
				switch(operacao) {
				case "+":
					resultado = num + ndois;
					break;
				case "-":
					resultado = num - ndois;
					break;
				case "*":
					resultado = num * ndois;
					break;
				case "/":
					resultado = num / ndois;
					break;
				default:
					System.out.println("Não digitou o símbolo da operação correspondente por favor tente novamente");
					break;
				}
			}
			catch(ArithmeticException e) {
				System.out.println("O número 0 não pode ser dividido escolha outro número");
				ndois= teclado.nextInt();
				resultado = num / ndois;
				System.out.println();
			}
			catch(InputMismatchException e) {
				System.out.println("Você digitou uma letra tente novamente");
				System.out.println();
				
			}
	
			System.out.println("O resultado da operação é " + resultado);
		teclado.close();

	}

}
