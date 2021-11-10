package exercicios;
import java.util.Scanner;
public class Array {

	public static void main(String[] args) {
		
		
		Scanner teclado = new Scanner(System.in);
		{
			int[] n = new int[5];
			int i;
			
			for(i=0; i<5; i++) {
				System.out.println("Escreva um valor para a posição "+ i);
				n[i]= teclado.nextInt();
				System.out.println();
			}
			
			for(i=0; i<n.length; i++) {
				System.out.println("O valor da posição "+ i + " é " + n[i]);
				System.out.println();
			}
		}
		teclado.close();
		

	}
	
}
