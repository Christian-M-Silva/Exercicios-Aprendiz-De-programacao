package exercicios;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner pessoa = new Scanner(System.in);

		int idade;
		String nome;
		float salario;

		System.out.println("Escreva seu nome");
		nome = pessoa.nextLine();

		System.out.println();

		System.out.println("Escreva sua idade");
		idade = pessoa.nextInt();

		System.out.println();

		System.out.println("Escreva seu sálario");
		salario = pessoa.nextFloat();

		System.out.println();

		System.out.println("O seu nome é " + nome + " sua idade é " + idade + " e seu sálario é " + salario);

		pessoa.close();
	}

}
