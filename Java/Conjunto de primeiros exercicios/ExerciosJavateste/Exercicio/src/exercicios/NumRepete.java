package exercicios;
import java.util.Scanner;

/* 

Fazer um programa para que o usuário digite três números e o 

programa verifique quais números são iguais (podem ser iguais dois  

números ou os três). Exibir mensagem de quais números são iguais. 

*/

public class NumRepete {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
			int n1, n2, n3;
			
			System.out.println("Digite o primeiro número inteiro:");
			n1 = teclado.nextInt();
			System.out.println();
			
			System.out.println("Digite o segundo número inteiro:");
			n2 = teclado.nextInt();
			System.out.println();
			
			System.out.println("Digite terceiro número inteiro:");
			n3 = teclado.nextInt();
			System.out.println();
		
	   teclado.close();
	   
	   if(n1==n2 && n1==n3) {
		   System.out.println("Os número " + n1 + " aparece três vezes");
	   }
	   else if(n1==n2 || n1==n3) {
		   System.out.println("O número " + n1 + " é o número repetido");
	   }
	   else {
		   System.out.println("O número " + n2 + " é o repetido");
	   }
	}

}
