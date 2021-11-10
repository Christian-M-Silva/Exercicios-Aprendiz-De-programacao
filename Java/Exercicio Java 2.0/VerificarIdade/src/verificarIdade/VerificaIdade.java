package verificarIdade;

import java.util.Scanner;

public class VerificaIdade {

	public static void main(String[] args) {
		/*
		 * Usando fundamentos básicos e de operadores relacionais da linguagem Java,
		 * desenvolva um código com duas variáveis: String “nome”, int “idade” e atribua
		 * valores à essas variáveis. Agora, utilizando a função System.out.print(),
		 * imprima o conteúdo de “nome”, junto com o resultado da verificação: “idade”
		 * maior ou igual 18 – true. “idade” menor que 18 – false. Preferencialmente
		 * usar a IDE Eclipse para desenvolver os códigos.
		 */
		
		Scanner teclado= new Scanner(System.in);
		String nome;
		int idade;
		
		nome= teclado.next();
		idade= teclado.nextInt();
		
		if(idade >= 18) {
			System.out.println(nome + " você é maior de idade");
		}
		else {
			System.out.println(nome + " você é menor de idade");
		}
		
		teclado.close();

	}

}
