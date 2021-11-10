package exercicio;

import java.util.Scanner;

public class VetorPar {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner teclado = new Scanner(System.in);
			int i, n;
			int[] num = new int[10];
			
			for(i=0; i<10; i++){
				System.out.println("Digite um número par e inteiro");
				n= teclado.nextInt();
				System.out.println();
				
				while(n%2!=0) {
					System.out.println("O número não é par digite outro número");
					n= teclado.nextInt();
					System.out.println();
				}
				
				num[i]= n;
			}
		teclado.close();
		
		for(i=0; i<num.length; i++){
			System.out.println("O número no indice " + i + " é " + num[i]);
		}
		

	}

}
