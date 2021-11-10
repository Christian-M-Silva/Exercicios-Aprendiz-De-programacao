package exercicio;

import java.util.Scanner;

public class ExceptionUm {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
			int ndois;
			int num;
			int resultado;
		
			System.out.println("Digite o primeiro número a ser dividido");
			num = teclado.nextInt();
			System.out.println();
			
			System.out.println("Digite o segundo valor a ser dividido");
			ndois = teclado.nextInt();
			
			try {
				resultado= num/ndois;
				System.out.println("O resultado é " + resultado);
			}
			catch(ArithmeticException e) {
				System.out.println("--------Não pode dividir por 0  " + e + "--------" ); 
				System.out.println("Digite outro número que não seja 0");
				ndois = teclado.nextInt();
				resultado= num/ndois;
				System.out.println("O resultado é " + resultado);
			}
			
			
			
		teclado.close();
		

	}

}
