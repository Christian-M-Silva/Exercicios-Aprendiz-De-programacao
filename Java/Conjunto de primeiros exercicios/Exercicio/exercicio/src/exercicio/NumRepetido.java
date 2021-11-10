package exercicio;

import java.util.Scanner;

public class NumRepetido {
/* Fazer um programa para preencher dois vetores de 5 posições cada com números quaisquer. Na sequência, verificar quais
número do primeiro vetor existem no segundo e informar no final do programa quantos números foram encontrados*/
	
	public static void main(String[] args) {
		
		int i, c;
		int[] num = new int[5];
		int[] ndois = new int[5];
		int q = 0;
		
		@SuppressWarnings("resource")
		Scanner teclado = new Scanner(System.in);
		
			for(i=0; i<5; i++) {
				System.out.println("Digite um número inteiro para o primeiro vetor");
				num[i]= teclado.nextInt();
				System.out.println();
			}
			
			System.out.println("----------------------------------------");
			System.out.println();
			
			for(c=0; c<5; c++) {
				System.out.println("Digite um número inteiro para o segundo vetor");
				ndois[c]= teclado.nextInt();
				System.out.println();
			}
		teclado.close();
		
		
		for(i=0; i<5; i++) {
			for(c=0; c<5; c++) {
				if(num[i] == ndois[c]) {
					q+=1;
				}
			}
		}
		
		System.out.println("Você digitou " + q + " repetidos");
	}

}
