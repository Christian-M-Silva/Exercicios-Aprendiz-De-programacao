package exercicios;
import java.util.Scanner;
public class DesafioWhile {

	public static void main(String[] args) {
		/*
		 * Fazer um programa que repita a entrada de dados até que p número digitado seja igual
		 *  ao número escolhido pelo sistema, que é o número 10.
		 */
		
		Scanner teclado = new Scanner (System.in);
			
			System.out.println("Digite um número:");
			int n = teclado.nextInt();
			System.out.println();
			
			while(n != 10) {
				System.out.println("Digite outro numero:");
				n = teclado.nextInt();
				System.out.println();
			}
			
			System.out.println("Parabéns você saiu do loop.");
		
		teclado.close();

	}

}
