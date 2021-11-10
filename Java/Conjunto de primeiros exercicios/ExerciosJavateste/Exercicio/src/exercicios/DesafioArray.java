package exercicios;

import java.util.Scanner;

public class DesafioArray {

	public static void main(String[] args) {
		
		
		Scanner teclado = new Scanner(System.in);
		teclado.close();
		
		int[] n = new int[5];
		int i;
		int x;
		
		for(i=0; i<5; i++) {
			System.out.println("Digite um número");
			n[i] = teclado.nextInt();
			System.out.println("");
		}
		
		for(x=0; x<=5; x++) {
			System.out.println("O valor do índice " + x + " é " + n[x]);
		}
		
		teclado.close();

	}

}
