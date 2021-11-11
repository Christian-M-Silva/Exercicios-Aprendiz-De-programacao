package tipoAnimal;

import java.util.Scanner;

public class Animal {
	
	String tipo;
	String nome;
	private String altura;
	private String peso;

	Scanner teclado = new Scanner(System.in);
	
	void nome() {
		System.out.println("Escreva o nome do animal");
		this.nome = teclado.next();
		System.out.println();
	}
	
	void tipo() { 
		System.out.println("Escreva se o tipo do animal é cachorro, gato ou peixe");
		this.tipo = teclado.next();
		System.out.println();
		String temp = this.tipo.toUpperCase();
		if((!temp.equals("CACHORRO")) && (!temp.equals("GATO"))) {
			this.tipo= "peixe";
		}
	}
	
	void setPeso(String peso) {
		System.out.println("Digite o peso do animal");
		peso = teclado.next();
		System.out.println();
		this.peso = peso;
	}
	
	String getPeso() {
		return peso;
	}
	
	void setAltura(String altura) {
		System.out.println("Digite a altura do animal");
		altura = teclado.next();
		this.altura = altura;
		System.out.println("____________________________");
	}
	
	String getAltura() {
		return altura;
	}

	void exibir() {
		System.out.println("O nome escolhido foi " + nome);
		System.out.println();
		System.out.println("O tipo escolhido foi " + tipo);
		System.out.println();
		System.out.println("O peso do animal é " + getPeso());
		System.out.println();
		System.out.println("A altura do animal é " + getAltura());
		System.out.println();
		teclado.close();
	}
	
}
