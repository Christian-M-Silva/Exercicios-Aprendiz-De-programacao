package soyrecoder;

import java.util.Scanner;

public class soyRecoder {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner pessoa = new Scanner (System.in);
			String nome;
			int idade;
			float salario;
			
			System.out.println("Digite o Nome");
			nome = pessoa.nextLine();
			
			System.out.println("Digite a idade");
			idade = pessoa.nextInt();
			
			System.out.println("Digite o Sálario");
			salario = pessoa.nextFloat();
			
			System.out.println("O nome da pessoa é " + nome);
			System.out.println("A idade da pessoa é " + idade);
			System.out.println("O sálario é " + salario);
		pessoa.close();
			
			
	}
	
}
