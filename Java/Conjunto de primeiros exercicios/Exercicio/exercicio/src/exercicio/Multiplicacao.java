package exercicio;
/*Fazer um programa para que o usuário informe um número e a tabuada daquele valor seja calculada
e exibida na tela. As multiplicações começam no valor 1 até o valor 9.
O número informado pelo usuário não pode ser zero e nem negativo. Exemplo: 2 x 1 = 2*/

import java.util.Scanner;

public class Multiplicacao {

	public static void main(String[] args) {
		
		int  i, n;
		int[] multiplicacao= new int[10];
		
		Scanner teclado = new Scanner(System.in);
		
			System.out.println("-----------Multiplicação do 1 até o 9-----------");
			System.out.println();
			
			System.out.println("Esceva um número que seja maior que zero");
			n= teclado.nextInt();
			System.out.println();
		
		teclado.close();
		
		if(n>0) {
			for(i=1; i<10; i++) {
				multiplicacao[i] = n * i;
				i= i + 4;
				System.out.println("O i vai receber" + i);
			}
			
			for(i=1; i<10; i++) {
				System.out.println(n + " x " + i + " = " + multiplicacao[i]);
				System.out.println();
			}
		}
		
		else {
			System.out.println("O número não pode ser igual ou menor a 0");
		}
		
		

	}

}
