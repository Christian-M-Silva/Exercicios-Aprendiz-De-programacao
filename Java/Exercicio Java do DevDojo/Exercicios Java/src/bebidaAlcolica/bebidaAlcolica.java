package bebidaAlcolica;

import java.util.Scanner;

public class bebidaAlcolica {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner (System.in);
		
		int idade = 0;
		
		System.out.println("Descubra se você pode beber bebidas alcoólicas");
		System.out.println("Digite sua idade");
		idade = teclado.nextInt();
		System.out.println();
		
		System.out.println((idade >= 18) ? "Você pode beber":"Você não pode beber"); 
		
		teclado.close();

	}

}
