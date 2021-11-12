package pessoa;
import java.util.Scanner;
public class Pessoa {
	/*
	 * Utilizando conceitos do paradigma de programação orientada a objetos,
	 * implemente uma class em Java, chamada “Pessoa” e em seguida desenvolva um
	 * código no qual o usuário informe o nome e idade de três pessoas e o programa
	 * deve armazenar esses dados em instâncias da classe “Pessoa”. Após isso, deve
	 * ocorrer uma verificação para saber qual pessoa tem a maior idade e imprimir
	 * no console o nome dessa pessoa. Crie ao menos dois métodos na classe
	 * “Pessoa”.
	 */
	
	String nome;
	int idade;
	
	Scanner teclado= new Scanner(System.in);
	
	void nome() {
		this.nome= teclado.next();
	}
	
	void idade() {
		this.idade= teclado.nextInt();
		}
	
	void fechar() {
		teclado.close();
	}
	
}
