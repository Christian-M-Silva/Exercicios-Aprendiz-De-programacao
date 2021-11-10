package exercicios;
import java.util.Scanner; //importei o Scanner
public class NumeroMeio {

	public static void main(String[] args) {
		/*Fazer um programa para que o usuário digite três números 
		 * e o programa deverá verificar 
		 * qual é o número do meio e exibir uma mensagem com o número.
		 *  O programa não poderá aceitar valor zero para nenhum dos três números. */
		
		Scanner teclado = new Scanner(System.in); //Abro o objeto scanner teclado
		
		int n1, n2, n3; //declaro minhas variaveis
		
		System.out.println("Digite um número");
		n1= teclado.nextInt();
		System.out.println(); //Faço o pedido para o usuario digita um número e a pessoa digita
		
		System.out.println("Digite um número");
		n2= teclado.nextInt();
		System.out.println(); //Faço o pedido para o usuario digita um número e a pessoa digita
		
		System.out.println("Digite um número");
		n3= teclado.nextInt();
		System.out.println(); //Faço o pedido para o usuario digita um número e a pessoa digita
		teclado.close(); //Fecho o meu objeto
		
		if(n1==0 || n2==0 || (n3==0) ) {
			System.out.println("O número 0 não é permitido"); //Se algum número for 0 acontecerá isso
		}
		else {
			System.out.println("O número do meio é " + n2); //Senão acontecerá isso
		}

	}

}
