package calculadoraIdade;

import java.util.Scanner;

public class CalculadoraIdade {

	public static void main(String[] args) {
	
		Scanner teclado = new Scanner (System.in);
		
		int idade = 0;
		String fase = "";
		
		System.out.println("Digite sua idade");
		idade = teclado.nextInt();
		System.out.println();
		
		if(idade <= 10) {
			fase = "uma criança";
		}else if(idade > 10 && idade < 12) {
			fase = "um pré-adolescente";
		}else if(idade >= 12 && idade < 18) {
			fase = "um adolescente";
		}else if(idade >= 18 && idade <=79) {
			fase = "um adulto";
		}else {
			fase = "um idoso";
		}
		
		System.out.println("Você é " + fase);
		
		teclado.close();
	}

}
