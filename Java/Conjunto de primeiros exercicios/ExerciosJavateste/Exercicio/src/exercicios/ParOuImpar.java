package exercicios;
import java.util.Scanner;

public class ParOuImpar {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
		int n;
		int nAuxiliar;
		
		System.out.println("Digite um número inteiro");
		n = teclado.nextInt();
		nAuxiliar = n % 2;
		System.out.println();
		
		switch(nAuxiliar) {
		case 0:
			System.out.println("O número " + n + " é par");
			System.out.println("O resultado da multiplicação por 4 é " + n * 4);
			break;
		default:
			System.out.println("O número " + n + " é impar");
			break;
		}
		teclado.close();
	}

}
