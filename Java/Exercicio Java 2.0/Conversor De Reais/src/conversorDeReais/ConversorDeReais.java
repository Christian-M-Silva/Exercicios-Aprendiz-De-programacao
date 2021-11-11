package conversorDeReais;

import java.util.Scanner;

public class ConversorDeReais {

	public static void main(String[] args) {
		
		
		Scanner teclado= new Scanner(System.in);
		
		double soma = 0;
		double total;
		String mensagem;
		int i = 0;
		
		System.out.println("Digite quantos produtos você deseja comprar ou já comprou. (Somente números)");
		int quantidade = teclado.nextInt();
		System.out.println();
		
		double[] valoresEmDolares = new double[quantidade];
		
		while(i<valoresEmDolares.length) {
			System.out.println("Digite os valores em dolár da mercadoria (somente números)");
			valoresEmDolares[i]= teclado.nextDouble();
			System.out.println();
			soma = valoresEmDolares[i] + soma;
			i++;
		}
		
		total= soma * 5.18;
		
		mensagem = (total>3000.00) ? "pagará 20%% de imposto":"está isento de imposto";
		
		System.out.printf(String.format("O valor total é %.2f R$ então você %s. ",total, mensagem));
		
		teclado.close();

	}

}
