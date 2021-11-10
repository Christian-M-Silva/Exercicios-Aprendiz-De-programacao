package exercicios;
import java.util.Scanner;
public class Multiplo {

	public static void main(String[] args) {
		/*Fazer um programa para que o usuário digite um número 
		 * e o programa verifique se o número é múltiplo de 2 ou de 5 ou de 10.
		 *  Exibir mensagem de erro caso o número digitado não seja 
		 *  múltiplo de nenhum destes. O programa não poderá permitir
		 *  que o número zero,
		 *  negativo e nem maior do que 100 seja digitado. 
		 * 
		 * */
		Scanner teclado = new Scanner(System.in);
		
		int n;
		
		System.out.println("Digite um número que não seja 0, negativo ou maior que 100:");
		n= teclado.nextInt();
		System.out.println();
		
		teclado.close();
		
		if(n>0 && n<=100) {
			if(n%2==0 || n%5==0 || n%10==0 ) {
				System.out.println("Você digitou o número certo");
			}
			else {
				System.out.println("Você digitou o número errado");
			}
		} 	
		else {
			System.out.println("Não aceitamos número 0, negativos e maiores que 100");
		}
	}

}
